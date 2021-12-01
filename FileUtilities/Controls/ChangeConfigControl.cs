using FileUtilities.Arguments;
using FileUtilities.StringSearch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUtilities.Controls
{
    public partial class ChangeConfigControl : UserControl, ILog
    {
        public StringSearcher StringSearcher { get; set; }
        public event EventHandler<string> LogInfo;
        public event EventHandler<string> LogWarn;
        public event EventHandler<LogFoundArgs> LogFound;
        public event EventHandler RememberScrollLocation;
        public event EventHandler ScrollToStart;
        public event EventHandler ScrollToBottom;

        public ChangeConfigControl()
        {
            InitializeComponent();
            StringSearcher = new StringSearcher();
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
            if (string.IsNullOrEmpty(tbxNodeName.Text))
            {
                LogWarn.Invoke(this, $"Text to find is not specified.{Environment.NewLine}");
                return;
            }

            var directory = tbxDirectory.Text;
            var findWhat = tbxNodeName.Text;
            var filters = tbxFilters.Text;
            var recursively = cbxRecursively.Checked;

            RememberScrollLocation.Invoke(this, new EventArgs());

            var xmlSearchResults = StringSearcher.FindXMLString(directory, findWhat, filters, recursively);

            LogInfo.Invoke(this, $"Total files count: {StringSearcher.AllFilesCount}{Environment.NewLine}");
            LogInfo.Invoke(this, $"Filters: {string.Join(", ", StringSearcher.Filters)}{Environment.NewLine}");
            LogInfo.Invoke(this, $"File count after filtering: {StringSearcher.FilteredFilesCount}{Environment.NewLine}");
            LogInfo.Invoke(this, $"Node name to find: \"{findWhat}\"{Environment.NewLine}");

            LogInfo.Invoke(this, $"Found {xmlSearchResults.Count} nodes in {StringSearcher.ElapsedSeconds} seconds!{Environment.NewLine}");

            foreach (var resultGroup in xmlSearchResults.GroupBy(x => x.File))
            {
                LogFound.Invoke(this, new LogFoundArgs($"File: {resultGroup.Key}{Environment.NewLine}", Color.Black));
                foreach (var result in resultGroup)
                {
                    LogFound.Invoke(this, new LogFoundArgs($"Node name: {result.Node.Name}, Value: {result.Node.InnerText}.", Color.Red));
                    LogFound.Invoke(this, new LogFoundArgs($"{Environment.NewLine}", Color.Black));
                }
            }

            ScrollToStart(this, new EventArgs());
        }

        private void btnReplaceWith_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDirectory.Text))
            {
                LogWarn.Invoke(this, ($"Directory is not specified.{Environment.NewLine}"));
                return;
            }
            if (string.IsNullOrEmpty(tbxNodeName.Text))
            {
                LogWarn.Invoke(this, $"Text to find is not specified.{Environment.NewLine}");
                return;
            }
            if (string.IsNullOrEmpty(tbxReplaceWith.Text))
            {
                LogWarn.Invoke(this, $"New value is not specified.{Environment.NewLine}");
                return;
            }

            var directory = tbxDirectory.Text;
            var findWhat = tbxNodeName.Text;
            var newValue = tbxReplaceWith.Text;
            var filters = tbxFilters.Text;
            var recursively = cbxRecursively.Checked;

            RememberScrollLocation.Invoke(this, new EventArgs());

            var xmlSearchResults = StringSearcher.FindXMLString(directory, findWhat, filters, recursively);

            LogInfo.Invoke(this, $"Total files count: {StringSearcher.AllFilesCount}{Environment.NewLine}");
            LogInfo.Invoke(this, $"Filters: {string.Join(", ", StringSearcher.Filters)}{Environment.NewLine}");
            LogInfo.Invoke(this, $"File count after filtering: {StringSearcher.FilteredFilesCount}{Environment.NewLine}");
            LogInfo.Invoke(this, $"Node name to find: \"{findWhat}\"{Environment.NewLine}");

            foreach(XmlSearchResult xmlSearchResult in xmlSearchResults)
            {
                var previousValue = xmlSearchResult.Node.InnerText;
                xmlSearchResult.Node.InnerText = newValue;
                xmlSearchResult.XmlDocument.Save(xmlSearchResult.File);
                LogFound.Invoke(this, new LogFoundArgs($"Change value from {previousValue} to {newValue}{Environment.NewLine}", Color.Green));
            }
            ScrollToStart(this, new EventArgs());
        }

    }
}
