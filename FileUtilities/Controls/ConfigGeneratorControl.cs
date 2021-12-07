using FileUtilities.Arguments;
using FileUtilities.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUtilities.Controls
{
    public partial class ConfigGeneratorControl : UserControl, ILog
    {
        public event EventHandler<string> LogInfo;
        public event EventHandler<string> LogWarn;
        public event EventHandler<LogFoundArgs> LogFound;
        public event EventHandler ScrollToBottom;
        public event EventHandler RememberScrollLocation;
        public event EventHandler ScrollToStart;

        public List<string> EINames { get; set; }
        public List<string> ConfigFiles { get; set; }

        public ConfigGeneratorControl()
        {
            InitializeComponent();
            EINames = new List<string>();
            ConfigFiles = new List<string>();
            bgWorker.DoWork += GenerateConfigs;
            bgWorker.RunWorkerCompleted += ConfigsGenerated;
            bgWorker.ProgressChanged += ProgressChanged;
        }

        private void btnDefaultDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                Description = "Choose folder with default config files:",
                ShowNewFolderButton = false,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var defaultDirectory = dialog.SelectedPath;
                tbxDefaultDirectory.Text = defaultDirectory;
                LogInfo.Invoke(this, ($"Default Directory changed to: {defaultDirectory}{Environment.NewLine}"));
                ConfigFiles = Directory.GetFiles(defaultDirectory, "*.xml", SearchOption.TopDirectoryOnly).ToList();
                LogInfo.Invoke(this, ($"Found: {ConfigFiles.Count} config files.{Environment.NewLine}"));
                if (cbxAssumeOutput.Checked)
                {
                    AssumeOutputDirectory();
                }
            }
        }

        private void cbxAssumeOutput_CheckedChanged(object sender, EventArgs e)
        {
            var defaultDirectory = tbxDefaultDirectory.Text;

            if (Directory.Exists(defaultDirectory))
            {
                AssumeOutputDirectory();
            }
        }

        private void AssumeOutputDirectory()
        {
            var defaultDirectory = tbxDefaultDirectory.Text;
            var outputDirectory = new DirectoryInfo(defaultDirectory).Parent.FullName;
            tbxOutputDirectory.Text = outputDirectory;
            LogInfo.Invoke(this, ($"Assuming Output directory to: {outputDirectory}{Environment.NewLine}"));
        }

        private void btnEIFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbxEIFile.Text = dialog.FileName;

                EINames = File.ReadAllLines(tbxEIFile.Text).ToList();
                LogInfo.Invoke(this, $"Found {EINames.Count} equipment instance names ({string.Join(", ", EINames.Take(3))}...){Environment.NewLine}");
            }
        }

        private void btnGenerateConfigs_Click(object sender, EventArgs e)
        {
            LogInfo.Invoke(this, $"Config folders generation started...{Environment.NewLine}");
            pgBar.Value = pgBar.Minimum;
            btnGenerateConfigs.Enabled = false;
            bgWorker.RunWorkerAsync();
        }

        private void GenerateConfigs(object sender, DoWorkEventArgs e)
        {
            if (EINames.Count == 0)
            {
                EINames = File.ReadAllLines(tbxEIFile.Text).ToList();
            }
            ConfigFiles = Directory.GetFiles(tbxDefaultDirectory.Text, "*.xml", SearchOption.TopDirectoryOnly).ToList();
            var outputDirectory = tbxOutputDirectory.Text;

            if (string.IsNullOrEmpty(tbxDefaultDirectory.Text))
            {
                LogWarn.Invoke(this, ($"Default directory is not specified.{Environment.NewLine}"));
                return;
            }
            if (string.IsNullOrEmpty(tbxOutputDirectory.Text))
            {
                LogWarn.Invoke(this, $"Output directory is not specified.{Environment.NewLine}");
                return;
            }

            double counter = 0;
            foreach (var eiName in EINames)
            {
                if (bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                var directory = Directory.CreateDirectory(Path.Combine(outputDirectory, eiName));

                foreach (var file in ConfigFiles)
                {
                    var destinationFile = Path.Combine(directory.FullName, new FileInfo(file).Name);
                    File.Copy(file, destinationFile, cbxOverwrite.Checked);
                }
                LogFound.Invoke(this, new LogFoundArgs($"Directory created: \"{directory.FullName}\" ({++counter} out of {EINames.Count}).{Environment.NewLine}", Color.Green));
                ScrollToBottom.Invoke(this, new EventArgs());
                var percentage = Math.Round((counter * 100.0) / EINames.Count);
                bgWorker.ReportProgress((int)percentage);
            }
        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgBar.Value = e.ProgressPercentage;
        }

        private void ConfigsGenerated(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                LogWarn.Invoke(this, $"{e.Error.Message}{Environment.NewLine}");
            }
            else if (e.Cancelled)
            {
                LogWarn.Invoke(this, $"Folder generation cancelled.{Environment.NewLine}");
            }
            else
            {
                LogFound.Invoke(this, new LogFoundArgs($"Each of the {ConfigFiles.Count} config files is copied to {EINames.Count} different folders " +
                    $"({ConfigFiles.Count * EINames.Count} files copied in total).{Environment.NewLine}", Color.Green));
            }
            btnGenerateConfigs.Enabled = true;
        }

        private void btnEditEIs_Click(object sender, EventArgs e)
        {
            EquipmentInstancesForm form = new EquipmentInstancesForm(EINames)
            {
                X = Cursor.Position.X,
                Y = Cursor.Position.Y,
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                EINames = form.EINames;
                LogInfo.Invoke(this, $"After editing, equipment instance names count: {EINames.Count} ({string.Join(", ", EINames.Take(3))}...){Environment.NewLine}");
            }
        }

        private void btnGenerateConfigs_EnabledChanged(object sender, EventArgs e)
        {
            btnCancel.Visible = !btnGenerateConfigs.Enabled;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bgWorker.CancelAsync();
        }
    }
}
