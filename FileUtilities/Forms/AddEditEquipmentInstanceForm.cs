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
    public partial class AddEditEquipmentInstanceForm : Form
    {
        public string EIName { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public AddEditEquipmentInstanceForm(string einame = "")
        {
            InitializeComponent();
            EIName = einame;
            tbxEIName.Text = EIName;

            Load += new EventHandler(AddEditEquipmentInstanceForm_Load);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxEIName.Text.Length > 0)
            {
                EIName = tbxEIName.Text;
            }
        }

        private void AddEditEquipmentInstanceForm_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(X, Y);
        }
    }
}
