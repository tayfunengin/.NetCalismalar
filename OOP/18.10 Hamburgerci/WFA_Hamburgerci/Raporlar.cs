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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            int siparisSayisi = 0;
            decimal esktraCiro = 0;
            int satilanUrunAdet = 0;


            foreach (Siparis item in Form1.siparisListesi)
            {
                ciro += item.ToplamTutar;
               
                foreach (Ekstra eks in item.Ekstralar)
                {
                   
                    esktraCiro += eks.Fiyat*item.Adet;
                }
                siparisSayisi++;
                satilanUrunAdet += item.Adet;
                listBox1.Items.Add(item);
            }
            lblCiro.Text = ciro.ToString("C2");
            lblEkstraGelir.Text = esktraCiro.ToString();
            lblSatilanUrunAdet.Text = satilanUrunAdet.ToString();
            lblToplamSiparis.Text = siparisSayisi.ToString();
           
            


        }
    }
}
