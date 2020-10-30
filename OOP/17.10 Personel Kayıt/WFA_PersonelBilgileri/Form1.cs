using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_PersonelBilgileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFotograf_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Personel Fotoğrafı| *.jpg;*.png;*.gif";
            DialogResult dR = ofd.ShowDialog();

            if (dR == DialogResult.OK)
            {

                pbFotograf.Image = Image.FromFile(ofd.FileName);
                pbFotograf.Tag = System.IO.Path.GetExtension(ofd.FileName);

            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));
                       
        }
       
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel = PersonelDoldur(personel);

            ListViewItem lvi = ListViewDoldur(personel);
            listView1.Items.Add(lvi);
            
           // listView1.Items.Add(ListViewDoldur(PersonelDoldur(personel)));

        }


        Personel PersonelDoldur(Personel p)
        {
            p.Ad = txtAd.Text;
            p.Soyad = txtSoyad.Text;
            p.TcKimlikNo = txtTcKimlikNo.Text;
            p.DogumTarihi = dtpDogumTarihi.Value;
            p.TelefonNo = txtTelefonNo.Text;
            p.Email = txtEmail.Text;
            p.Adres = txtAdres.Text;
            p.IseGirisTarih = dtpIseGirisTarih.Value;
            p.Unvan =(Unvan)Enum.Parse(typeof(Unvan), cmbUnvan.Text);            
            if(pbFotograf.Tag !=null)
            {
                p.Fotograf = Guid.NewGuid() + pbFotograf.Tag.ToString();
                pbFotograf.Image.Save(Application.StartupPath + "/Images/" + p.Fotograf);
            }
            return p;
        }

        ListViewItem ListViewDoldur(Personel p)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = p.TcKimlikNo;
            lvi.SubItems.Add(p.Ad);
            lvi.SubItems.Add(p.Soyad);
            lvi.SubItems.Add(p.DogumTarihi.ToShortDateString());
            lvi.SubItems.Add(p.TelefonNo);
            lvi.SubItems.Add(p.Email);
            lvi.SubItems.Add(p.Adres);
            lvi.SubItems.Add(p.IseGirisTarih.ToShortDateString());
            lvi.SubItems.Add(p.Unvan.ToString());
            lvi.Tag = p;
            return lvi;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            PersonelGuncelle();
        }

        void PersonelGuncelle()
        {           
            Personel yeniPersonel = new Personel();
            yeniPersonel = PersonelDoldur(yeniPersonel);

            ListViewItem lvi = new ListViewItem();
            lvi = ListViewDoldur(yeniPersonel);


            if(listView1.SelectedItems.Count == 1)
            {
                listView1.SelectedItems[0].Text = lvi.Text;
                listView1.SelectedItems[0].SubItems[1] = lvi.SubItems[1];
                listView1.SelectedItems[0].SubItems[2] = lvi.SubItems[2];
                listView1.SelectedItems[0].SubItems[3] = lvi.SubItems[3];
                listView1.SelectedItems[0].SubItems[4] = lvi.SubItems[4];
                listView1.SelectedItems[0].SubItems[5] = lvi.SubItems[5];
                listView1.SelectedItems[0].SubItems[6] = lvi.SubItems[6];
                listView1.SelectedItems[0].SubItems[7] = lvi.SubItems[7];
                listView1.SelectedItems[0].SubItems[8] = lvi.SubItems[8];
                listView1.SelectedItems[0].Tag = yeniPersonel;
                
            }
            else
            {
                MessageBox.Show("Lüften Güncellemek İstediğiniz Satırı Seçin");
            }
            
          
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            PersonelSil();
        }

        void PersonelSil()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if(item.Selected)
                {
                    item.Remove();
                }
                
            }
            
        }
    }
}
