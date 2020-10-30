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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Kitap> kitapListesi = new List<Kitap>();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            

            Kitap kitap = new Kitap();
            kitap.KitapAdi = txtKitapAd.Text;
            kitap.Yazar = txtYazar.Text;
            kitap.Tur = txtTur.Text;
            kitap.SayfaSayisi = Convert.ToInt32(nudSayfa.Value);
            kitap.YayinEvi = txtYayinEvi.Text;
            kitap.Fiyat = nudFiyat.Value;

            kitapListesi.Add(kitap);

        }

        private void BtnAktar_Click(object sender, EventArgs e)
        {
            KitapForm kitapForm = new KitapForm(kitapListesi);
            kitapForm.Show();            

            ElektronikForm telefonForm = new ElektronikForm(telefonListesi);
            telefonForm.Show();

            MuzikForm muzikForm = new MuzikForm(muzikListesi);
            muzikForm.Show();

            this.Hide();
        }

        List<Telefon> telefonListesi = new List<Telefon>();
        private void Button1_Click(object sender, EventArgs e)
        {
            Telefon telefon = new Telefon();

            telefon.Marka = txtMarka.Text;
            telefon.Model = txtModel.Text;
            telefon.Renk = txtRenk.Text;
            telefon.Fiyat = nudTelefonFiyat.Value;

            telefonListesi.Add(telefon);
        }
        List<Muzik> muzikListesi = new List<Muzik>();
        private void Button2_Click(object sender, EventArgs e)
        {
            Muzik muzik = new Muzik();

            muzik.SanatciAdi = txtSanatciAdi.Text;
            muzik.MedyaCinsi = txtMedyaTuru.Text;
            muzik.Fiyat = nudMuzikFiyat.Value;

            muzikListesi.Add(muzik);

        }


    }
}
