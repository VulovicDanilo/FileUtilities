using FileUtilities.Arguments;
using FileUtilities.Forms;
using FileUtilities.StringSearch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUtilities.Controls
{
    public partial class ReplaceInFilesControl : UserControl, ILog
    {
        public StringSearcher StringSearcher { get; set; }
        public List<string> AllowedFolders { get; set; }

        public event EventHandler<string> LogInfo;
        public event EventHandler<string> LogWarn;
        public event EventHandler<LogFoundArgs> LogFound;
        public event EventHandler RememberScrollLocation;
        public event EventHandler ScrollToStart;
        public event EventHandler ScrollToBottom;

        public ReplaceInFilesControl()
        {
            InitializeComponent();
            StringSearcher = new StringSearcher();
            AllowedFolders = new List<string>();
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                Description = "Choose folder for string search",
                ShowNewFolderButton = false,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbxDirectory.Text = dialog.SelectedPath;
                LogInfo.Invoke(this, ($"Directory changed to: {dialog.SelectedPath}.{Environment.NewLine}"));
            }
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDirectory.Text))
            {
                LogWarn.Invoke(this, ($"Directory is not specified.{Environment.NewLine}"));
                return;
            }
            if (string.IsNullOrEmpty(tbxFindWhat.Text))
            {
                LogWarn.Invoke(this, $"Text to find is not specified.{Environment.NewLine}");
                return;
            }

            var directory = tbxDirectory.Text;
            var findWhat = tbxFindWhat.Text;
            var filters = tbxFilters.Text;
            var recursively = cbxRecursively.Checked;
            var matchCase = cbxMatchCase.Checked;

            RememberScrollLocation.Invoke(this, new EventArgs());

            var searchResults = StringSearcher.FindString(directory, AllowedFolders, findWhat, filters, recursively, matchCase);

            LogInfo.Invoke(this, $"Total files count: {StringSearcher.AllFilesCount}{Environment.NewLine}");
            LogInfo.Invoke(this, $"Filters: {string.Join(", ", StringSearcher.Filters)}{Environment.NewLine}");
            LogInfo.Invoke(this, $"File count after filtering: {StringSearcher.FilteredFilesCount}{Environment.NewLine}");
            LogInfo.Invoke(this, $"String to find: \"{findWhat}\"{Environment.NewLine}");

            LogInfo.Invoke(this, $"Found {searchResults.Count} occurences in {StringSearcher.ElapsedSeconds} seconds!{Environment.NewLine}");

            foreach (var resultGroup in searchResults.GroupBy(x => x.File))
            {
                LogFound.Invoke(this, new LogFoundArgs($"File: {resultGroup.Key}{Environment.NewLine}", Color.Black));
                foreach (var result in resultGroup.OrderBy(x => x.LineNumber).ThenBy(x => x.ColumnNumber))
                {
                    var prePattern = result.LineContent.Substring(0, result.ColumnNumber - 1);
                    var postPattern = result.LineContent.Substring(result.ColumnNumber + result.Pattern.Length - 1);

                    LogFound.Invoke(this, new LogFoundArgs($"{prePattern}", Color.Gray));
                    LogFound.Invoke(this, new LogFoundArgs($"{result.Pattern}", Color.Red));
                    LogFound.Invoke(this, new LogFoundArgs($"{postPattern}", Color.Gray));
                    LogFound.Invoke(this, new LogFoundArgs($", at line: {result.LineNumber}, column: {result.ColumnNumber}", Color.Green));
                    LogFound.Invoke(this, new LogFoundArgs($"{Environment.NewLine}", Color.Black));
                }
            }

            ScrollToStart.Invoke(this, new EventArgs());
        }

        private void btnReplaceInFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDirectory.Text))
            {
                LogWarn.Invoke(this, $"Directory is not specified.");
                return;
            }
            if (string.IsNullOrEmpty(tbxFindWhat.Text))
            {
                LogWarn.Invoke(this, $"Text to find is not specified.");
                return;
            }

            var directory = tbxDirectory.Text;
            var findWhat = tbxFindWhat.Text;
            var replaceWith = tbxReplaceWith.Text;
            var filters = tbxFilters.Text;
            var recursively = cbxRecursively.Checked;
            var matchCase = cbxMatchCase.Checked;

            RememberScrollLocation.Invoke(this, new EventArgs());

            var searchResults = StringSearcher.FindString(directory, AllowedFolders, findWhat, filters, recursively, matchCase);
            int occurencesReplaced = 0;

            foreach (var searchGroup in searchResults.GroupBy(x => x.File))
            {
                var filename = searchGroup.Key;

                var fileContent = File.ReadAllText(filename);
                foreach (var searchResult in searchGroup)
                {
                    fileContent = fileContent.Replace(searchResult.Pattern, replaceWith);
                    occurencesReplaced++;
                }
                File.SetAttributes(filename, ~FileAttributes.ReadOnly & File.GetAttributes(filename));
                File.WriteAllText(filename, fileContent);
            }
            LogInfo.Invoke(this, $"Replaced {occurencesReplaced} out of {searchResults.Count} occurences.{Environment.NewLine}");

            ScrollToStart.Invoke(this, new EventArgs());
        }

        private void btnFolderFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDirectory.Text))
            {
                LogWarn.Invoke(this, $"Directory is not specified.");
                return;
            }

            var directories = Directory.GetDirectories(tbxDirectory.Text).ToList();
            var allowedFoldersParam = new List<bool>();
            foreach (var directory in directories)
            {
                allowedFoldersParam.Add(AllowedFolders.Contains(directory));
            }
            FolderFilterForm form = new FolderFilterForm(directories, allowedFoldersParam);

            if (form.ShowDialog() == DialogResult.OK)
            {
                AllowedFolders = form.CheckedFolders;
            }
        }
    }
}
