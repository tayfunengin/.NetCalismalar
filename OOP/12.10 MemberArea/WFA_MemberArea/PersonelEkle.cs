using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MemberArea
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        
               
       public static List<Personel> personelListesi = new List<Personel>();
        public void BtnEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel(txtAd.Text, txtSoyad.Text, txtTckn.Text,txtAdres.Text);
          
            personelListesi.Add(personel);

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTckn.Text = "";
            txtAdres.Text = "";
            dtpIseGiris.Value = DateTime.Today;
        }
    }
}
