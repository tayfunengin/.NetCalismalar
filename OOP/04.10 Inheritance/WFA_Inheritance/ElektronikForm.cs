using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Inheritance
{
    public partial class ElektronikForm : Form
    {

        List<Telefon> _telefon;
        public ElektronikForm(List<Telefon> value)
        {
            _telefon = value;
            InitializeComponent();
        }

        private void ElektronikForm_Load(object sender, EventArgs e)
        {
            foreach (Telefon item in _telefon)
            {
                string format = $" {item.Marka} {item.Model} {item.Renk} Renk {item.Fiyat}TL";
                listBox1.Items.Add(format);
            }
        }
    }
}
