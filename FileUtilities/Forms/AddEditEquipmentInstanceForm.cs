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
        public AddEditEquipmentInstanceForm(string einame = "")
        {
            InitializeComponent();
            EIName = einame;
            tbxEIName.Text = EIName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxEIName.Text.Length > 0)
            {
                EIName = tbxEIName.Text;
            }
        }
    }
}
