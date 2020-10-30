using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Hamburgerci.Tools
{
   public class ToolSettings
    {
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control ctrl in collection)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.Clear();
                }
                else if (ctrl is CheckBox)
                {
                    CheckBox chk = (CheckBox)ctrl;
                    chk.Checked = false;
                }
                else if (ctrl is FlowLayoutPanel)
                {
                    FlowLayoutPanel flp = (FlowLayoutPanel)ctrl;
                    Temizle(flp.Controls);
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
                else if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 1;
                }
                else if (ctrl is Label)
                {
                    Label lbl = (Label)ctrl;
                    if (lbl.Name == "lblToplamTutar") lbl.Text = "0";
                }
                else if (ctrl is ListBox)
                {
                    ListBox lsb = (ListBox)ctrl;
                    lsb.Items.Clear();
                }


            }
        }
    }
}
