using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUtilities.Extensions
{
    public static class ListViewExtensions
    {
        public static void CheckAllItems(this ListView listView)
        {
            listView.SetCheckStateOnItems(true);
        }

        public static void UncheckAllItems(this ListView listView)
        {
            listView.SetCheckStateOnItems(false);
        }

        private static void SetCheckStateOnItems(this ListView listView, bool checkedState)
        {
            foreach (ListViewItem item in listView.Items)
            {
                item.Checked = checkedState;
            }
        }
    }
}
