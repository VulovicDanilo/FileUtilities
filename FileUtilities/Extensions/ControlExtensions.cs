using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUtilities.Extensions
{
    public static class ControlExtensions
    {
        public static IEnumerable<T> FindChildControlsOfType<T>(this Control control)
        {
            foreach (var childControl in control.Controls.Cast<Control>())
            {
                if (childControl is T childT)
                {
                    yield return childT;
                }
                else
                {
                    foreach (var next in FindChildControlsOfType<T>(childControl))
                    {
                        yield return next;
                    }
                }
            }
        }
    }
}
