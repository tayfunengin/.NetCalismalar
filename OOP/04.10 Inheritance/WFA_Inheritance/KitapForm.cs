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
    public partial class KitapForm : Form
    {

        List<Kitap> _kitap;
        public KitapForm(List<Kitap> value)
        {
            _kitap = value;
            InitializeComponent();
        }

        private void KitapForm_Load(object sender, EventArgs e)
        {
            foreach (Kitap item in _kitap)
            {
                string format = $"{item.KitapAdi} {item.Yazar} {item.Tur} {item.SayfaSayisi} Sayfa {item.Fiyat} TL ";
                listBox1.Items.Add(format);              

            }
        }
    }
}
