using FileUtilities.Arguments;
using FileUtilities.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUtilities
{
    public partial class FileUtilitiesForm : Form
    {
        public int ScrollLocation { get; set; }
        public FileUtilitiesForm()
        {
            InitializeComponent();
            var iLogControls = this.FindChildControlsOfType<ILog>();
            foreach (var control in iLogControls)
            {
                control.LogInfo += LogInfo;
                control.LogWarn += LogWarn;
                control.LogFound += LogFound;
                control.RememberScrollLocation += RememberScrollLocation;
                control.ScrollToStart += ScrollToStart;
                control.ScrollToBottom += ScrollToBottom;
            }
        }

        private void ScrollToBottom(object sender, EventArgs e)
        {
            rtbInfo.ScrollToCaret();
        }

        private void LogFound(object sender, LogFoundArgs e)
        {
            rtbInfo.AppendText(e.Message, e.Color);
        }

        private void ScrollToStart(object sender, EventArgs e)
        {
            rtbInfo.Select(ScrollLocation, 0);
            rtbInfo.ScrollToCaret();
        }

        private void RememberScrollLocation(object sender, EventArgs e)
        {
            rtbInfo.AppendText($"==================================================================" +
                $"==============================================================================", Color.Black);
            LogNewLine();
            ScrollLocation = rtbInfo.GetFirstCharIndexOfCurrentLine();
        }

        private void LogInfo(object sender, string message)
        {
            rtbInfo.AppendText(message, Color.Blue);
        }

        private void LogWarn(object sender, string message)
        {
            rtbInfo.AppendText($"[WARN] - {message}", Color.Red);
        }

        private void LogNewLine()
        {
            rtbInfo.AppendText($"{Environment.NewLine}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbInfo.Clear();
        }
    }
}
