using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUtilities.Forms
{
    public partial class EquipmentInstancesForm : Form
    {
        public List<string> EINames { get; set; }
        public  int X { get; set; }
        public int Y { get; set; }

        public EquipmentInstancesForm(List<string> einames)
        {
            InitializeComponent();
            EINames = einames;
            RefreshList();
            lbxEINames_SelectedValueChanged(this, new EventArgs());

            Load += new EventHandler(EquipmentInstancesForm_Load);
        }

        private void RefreshList()
        {
            lbxEINames.DataSource = null;
            lbxEINames.DataSource = EINames;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditEquipmentInstanceForm form = new AddEditEquipmentInstanceForm()
            {
                X = Cursor.Position.X,
                Y = Cursor.Position.Y,
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(form.EIName))
                {
                    MessageBox.Show("Equipment instance name cannot be empty.");
                    return;
                }
                EINames.Add(form.EIName);
                RefreshList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var index = lbxEINames.SelectedIndex;
            AddEditEquipmentInstanceForm form = new AddEditEquipmentInstanceForm(EINames.ElementAt(index))
            {
                X = Cursor.Position.X,
                Y = Cursor.Position.Y,
            };

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(form.EIName))
                {
                    MessageBox.Show("Equipment instance name cannot be empty.");
                    return;
                }
                EINames[index] = form.EIName;
                RefreshList();
            }
        }

        private void lbxEINames_SelectedValueChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            if (lbxEINames.SelectedItems.Count == 1)
            {
                btnEdit.Enabled = true;
            }
            if (lbxEINames.SelectedItems.Count > 0)
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (int index in lbxEINames.SelectedIndices.Cast<int>().Select(x => x).Reverse())
            {
                EINames.RemoveAt(index);
            }
            RefreshList();
        }

        private void EquipmentInstancesForm_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(X, Y);
        }
    }
}
