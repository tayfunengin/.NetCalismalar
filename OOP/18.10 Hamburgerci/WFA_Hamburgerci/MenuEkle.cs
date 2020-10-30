using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Hamburgerci
{
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Menu yeniMenu = new Menu();
            yeniMenu.Ad = txtAd.Text;
            yeniMenu.Fiyat = nudFiyat.Value;            

            Form1.menuListesi.Add(yeniMenu);

            MessageBox.Show($"{yeniMenu} eklendi");

            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
