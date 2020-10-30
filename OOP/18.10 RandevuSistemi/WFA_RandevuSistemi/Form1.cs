using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RandevuSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> saatler = new List<string>() { "10:30", "11:00", "11:30", "12:00" };
        List<Randevu> randevuListesi = new List<Randevu>();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string saat in saatler)
            {
                Button button = new Button();
                button.Text = saat;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += Button_Click;
            }          
                       

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Randevu randevu = new Randevu();


            randevu.Ad = txtAd.Text;
            randevu.Soyad = txtSoyad.Text;
            randevu.TcKimlikNo = txtTcKimlikNo.Text;
            randevu.Brans = (Brans)cmbRandevuBrans.SelectedItem;
            randevu.Doktor =(Doktor)cmbRandevuDoktor.SelectedItem;
            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Bu saat için daha önce randevu alınmış, lütfen diğer saatleri deneyin");
            }
            else
            {
                if (dtpRandevuTarih.Value < DateTime.Now)
                {
                    MessageBox.Show("Geçmiş tarihe randevu alınmaz!");
                }
                else
                {
                    randevu.RandevuTarih = dtpRandevuTarih.Value.ToShortDateString();
                }
                if (randevu.Ad == "" || randevu.Soyad == "" || randevu.TcKimlikNo == "")
                {
                    MessageBox.Show("Lütfen bütün alanları doldurun");
                }
                else
                {
                    foreach (Randevu r in randevuListesi)
                    {
                        if (r.TcKimlikNo.Equals(txtTcKimlikNo.Text))
                            MessageBox.Show("Bu TC kimlik numarası için daha önce randevu oluşturulmuş");
                        return;
                    }

                    MessageBox.Show("Randevunuz başarı ile oluşturuldu");
                    txtAd.Text = "";
                    txtSoyad.Clear();
                    txtTcKimlikNo.Text = "";
                    dtpRandevuTarih.Value = DateTime.Now;
                    btn.BackColor = Color.Red;
                    randevuListesi.Add(randevu);

                    ListViewItem liv = new ListViewItem();
                    liv.Text = randevu.TcKimlikNo;
                    liv.SubItems.Add(randevu.Ad);
                    liv.SubItems.Add(randevu.Soyad);
                    liv.SubItems.Add(randevu.RandevuTarih.ToString());
                    liv.SubItems.Add(randevu.Brans.ToString());
                    liv.SubItems.Add(randevu.Doktor.ToString());

                    listView1.Items.Add(liv);
                }
            }           
            

        }
        List<Brans> bransListesi = new List<Brans>();
        private void BtnBransEkle_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans();
            brans.Ad = txtBransAd.Text;
            brans.Doktorlar = new List<Doktor>();
            bransListesi.Add(brans);

            cmbDoktorBrans.DataSource = bransListesi.ToList();
            txtBransAd.Text = "";
        }

        private void BtnDoktorEkle_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            doktor.Ad = txtDoktorAd.Text;
            Brans b = (Brans)cmbDoktorBrans.SelectedItem;
            b.Doktorlar.Add(doktor);
            txtDoktorAd.Text = "";
        }

        private void CmbRandevuBrans_Enter(object sender, EventArgs e)
        {
            cmbRandevuBrans.DataSource = bransListesi.ToList();
        }

        private void CmbRandevuDoktor_Enter(object sender, EventArgs e)
        {
            Brans b = (Brans)cmbRandevuBrans.SelectedItem;

            cmbRandevuDoktor.DataSource = b.Doktorlar.ToList();
        }
    }
}
