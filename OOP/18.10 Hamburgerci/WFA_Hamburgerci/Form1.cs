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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public List<Ekstra> ekstaListesi = new List<Ekstra>()
            {
                new Ekstra
                {
                    EkstraAd = "Mayonez",
                    Fiyat = 0.5m,
                },
                new Ekstra
                {
                    EkstraAd="Hardal",
                    Fiyat =1,
                },
                new Ekstra
                {
                    EkstraAd ="BBQ",
                    Fiyat = 2,
                },
                new Ekstra
                {
                    EkstraAd ="Buffalo",
                    Fiyat = 2.5m,
                }

            };
        public  static List<Menu> menuListesi = new List<Menu>()
            {
                new Menu()
                {
                    Ad = "Whooper",
                    Fiyat = 18
                },
                new Menu()
                {
                    Ad = "Chicken",
                    Fiyat = 15,
                },
                new Menu()
                {
                    Ad = "Bigmag",
                    Fiyat = 14,
                },

            };
        private void Form1_Load(object sender, EventArgs e)
        {
         

            foreach (Menu item in menuListesi)
            {
                cbMenuler.Items.Add(item);
            }

          

            foreach (Ekstra item in ekstaListesi)
            {
                CheckBox chk = new CheckBox();
                chk.Text = item.EkstraAd;
                chk.Tag = item;
                flpExtraMalzemeler.Controls.Add(chk);
            }


        }

       public static List<Siparis> siparisListesi = new List<Siparis>();
        private void BtnSiparisEkle_Click(object sender, EventArgs e)
        {
            
            Siparis siparis = new Siparis();

            siparis.SeciliMenu = (Menu)cbMenuler.SelectedItem;
            if (rbKucuk.Checked)
                siparis.Boyut = Boyut.Küçük;
            else if (rbOrta.Checked)
                siparis.Boyut = Boyut.Orta;
            else
                siparis.Boyut = Boyut.Büyük;

            siparis.Ekstralar = new List<Ekstra>();
            foreach (CheckBox item in flpExtraMalzemeler.Controls)
            {
                CheckBox chk = (CheckBox)item;
                if (chk.Checked)
                    siparis.Ekstralar.Add((Ekstra)chk.Tag);
            }

            siparis.Adet = (int)nmrAdet.Value;
            siparis.Hesapla();
            lstSiparisler.Items.Add(siparis);
            siparisListesi.Add(siparis);

            ToplamTutar();
            
        }

        public decimal ToplamTutar()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                Siparis spr = (Siparis)lstSiparisler.Items[i];
                toplamTutar += spr.ToplamTutar;
            }                
            
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            
            return toplamTutar;
        }

        private void BtmSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Toplam Sipariş Ücreti =" + ToplamTutar().ToString("C2"), "Siparişi Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(dR == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi");
            }
            else
            {
                MessageBox.Show("Siparişiniz Tamamlandı");
                Tools.ToolSettings.Temizle(this.Controls);
                lstSiparisler.Items.Clear();
            }
        }

        private void BtnMenuEkle_Click(object sender, EventArgs e)
        {
            MenuEkle menuEkle = new MenuEkle();
            menuEkle.Show();
            this.Hide();
        }

        private void BtnEktraEkle_Click(object sender, EventArgs e)
        {
            EkstraEkle ekstraEkle = new EkstraEkle();
            ekstraEkle.Show();
            this.Hide();
        }

        private void BtnRaporAc_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
            Form1 form = new Form1();
            form.Hide();


        }
    }
}
