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
    public partial class EkstraEkle : Form
    {
        public EkstraEkle()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Ekstra yeniEkstra = new Ekstra();

            yeniEkstra.EkstraAd = txtAd.Text;
            yeniEkstra.Fiyat = nudFiyat.Value;
            Form1 form = new Form1();
            form.ekstaListesi.Add(yeniEkstra);
           MessageBox.Show($"{yeniEkstra} eklendi");
            form.Show();
            this.Close();

        }
    }
}
