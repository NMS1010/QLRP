using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.Utils.FormControls
{
    public class ClearControls
    {
        public static void ClearContent(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox || control is RichTextBox)
                {
                    control.Text = "";
                }
                else if (control is DateTimePicker)
                {
                    (control as DateTimePicker).Value = DateTime.Now;
                }
                else if (control is CheckedListBox)
                {
                    foreach (int i in (control as CheckedListBox).CheckedIndices)
                    {
                        (control as CheckedListBox).SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
        }
    }
}