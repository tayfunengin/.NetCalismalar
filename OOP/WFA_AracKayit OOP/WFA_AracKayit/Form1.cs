using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Marka
            cmbMarka.Items.Add("Mercedes");
            cmbMarka.Items.Add("Audi");
            cmbMarka.Items.Add("BMW");

            //Yakıt
            cmbYakit.Items.Add("Benzin");
            cmbYakit.Items.Add("Dizel");

            //Renk
            cmbRenk.Items.Add("Mavi");
            cmbRenk.Items.Add("Kırmızı");
            cmbRenk.Items.Add("Siyah");
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            switch (cmbMarka.Text)
            {
                case "Mercedes":
                    cmbModel.Items.Add("A Serisi");
                    cmbModel.Items.Add("C Serisi");
                    cmbModel.Items.Add("E Serisi");
                    break;
                case "Audi":
                    cmbModel.Items.Add("A3");
                    cmbModel.Items.Add("A4");
                    cmbModel.Items.Add("A5");
                    break;
                case "BMW":
                    cmbModel.Items.Add("3.20");
                    cmbModel.Items.Add("4.20");
                    cmbModel.Items.Add("5.20");
                    break;
            }
        }

        //Arac arac = new Arac();
        List<Arac> aracLitesi = new List<Arac>();

        void AracKaydet()
        {
            Arac arac = new Arac();
            arac.Marka = cmbMarka.Text;
            arac.Model = cmbModel.Text;
            arac.KasaTipi = cmbKasa.Text;
            arac.YakitTuru = cmbYakit.Text;
            arac.VitesTipi = cmbVites.Text;
            arac.ModelYili = dateTimePicker1.Text;
            arac.Renk = cmbRenk.Text;
            if(arac.Marka =="" || arac.Model == "")
            {
                MessageBox.Show("Lüften Marka ve Model seçiniz!");
            }
            else
            {
                aracLitesi.Add(arac);
            }
            
            cmbMarka.SelectedIndex = -1;
        }
        private void BtnAracKaydet_Click(object sender, EventArgs e)
        {            

            AracKaydet();         
           
        }

        void AracEkle()
        {
            if (aracLitesi.Count>0)
            {

                foreach (Arac item in aracLitesi)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.UseItemStyleForSubItems = false;

                    lvi.Text = item.Marka;
                    lvi.SubItems.Add(item.Model);
                    lvi.SubItems.Add(item.YakitTuru);
                    lvi.SubItems.Add(item.KasaTipi);
                    lvi.SubItems.Add(item.VitesTipi);
                    lvi.SubItems.Add(item.Renk);
                    if (lvi.SubItems[5].Text == "Mavi")
                    {
                        lvi.SubItems[5].BackColor = Color.Blue;
                        lvi.SubItems[5].ForeColor = Color.White;
                    }
                    else if (item.Renk == "Kırmızı")
                    {
                        lvi.SubItems[5].BackColor = Color.Red;
                        lvi.SubItems[5].ForeColor = Color.White;
                    }
                    else if (item.Renk == "Siyah")
                    {
                        lvi.SubItems[5].BackColor = Color.Black;
                        lvi.SubItems[5].ForeColor = Color.White;
                    }
                    lvi.SubItems.Add(item.ModelYili);

                    listView1.Items.Add(lvi);                   
                    
                }
                aracLitesi.Clear();
            }
            else
            {
                MessageBox.Show("Önce araç kaydetmelisiniz!");
            }

        }

        private void BtnAracEkle_Click(object sender, EventArgs e)
        {
                    
            AracEkle();          
                       
        }
              
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Silmek için araç ekleyin");
            }
            else
            {

                DialogResult dR2 = MessageBox.Show("seçilen aracı silmek istiyor mussun?", "araç silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dR2 == DialogResult.Yes)

                    for (int i = listView1.SelectedItems.Count; i > 0; i--)
                    {
                        listView1.Items.Remove(listView1.SelectedItems[i-1]);
                    }                    

                else
                {
                    MessageBox.Show("silinmedi");
                }

            }
        }

        
    }
}
