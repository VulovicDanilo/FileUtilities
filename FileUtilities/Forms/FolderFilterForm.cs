using FileUtilities.Extensions;
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

namespace FileUtilities.Forms
{
    public partial class FolderFilterForm : Form
    {
        private readonly List<string> allFolders = new List<string>();
        public List<string> CheckedFolders { get; private set; }
        public List<string> UncheckedFolders { get; private set; }

        public FolderFilterForm(List<string> directories, List<bool> allowedFolders)
        {
            InitializeComponent();
            lvFolders.Items.Clear();
            lvFolders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            allFolders = directories;
            CheckedFolders = new List<string>();
            UncheckedFolders = new List<string>();
            PopulateFolders(directories, allowedFolders);
        }

        private void PopulateFolders(List<string> directories, List<bool> allowedFolders)
        {
            lvFolders.Items.Clear();
            foreach (var dir in directories.Zip(allowedFolders, (directory, allowed) => new {directory, allowed }))
            {
                var item = lvFolders.Items.Add(dir.directory);
                item.Checked = dir.allowed;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CheckedFolders.Clear();
            UncheckedFolders.Clear();

            CheckedFolders.AddRange(lvFolders.CheckedItems.Cast<ListViewItem>().Select(x => x.Text));
            UncheckedFolders.AddRange(allFolders.Except(CheckedFolders));
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            lvFolders.CheckAllItems();
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            lvFolders.UncheckAllItems();
        }
    }
}
