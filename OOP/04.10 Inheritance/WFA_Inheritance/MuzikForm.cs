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
    public partial class MuzikForm : Form
    {

        List<Muzik> _muzik;
        public MuzikForm(List<Muzik> value)
        {
            _muzik= value;
            InitializeComponent();
        }

        private void MuzikForm_Load(object sender, EventArgs e)
        {
            foreach (Muzik item in _muzik)
            {
                string format = $"{item.SanatciAdi} {item.MedyaCinsi} {item.Fiyat} TL";
                listBox1.Items.Add(format);
            }
        }
    }
}
