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
    public partial class PersonelForm : Form
    {
      
        public PersonelForm()
        {
            
            InitializeComponent();
        }

       

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            personelEkle.Show();
            

        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
           

        }

        private void BtnFormuAktar_Click(object sender, EventArgs e)
        {

            if (PersonelEkle.personelListesi.Count == 0)
            {
                MessageBox.Show("Form boş, aktarmak için önce personel eklemenniz gerekmektedir");
            }
            else
            {


                foreach (Personel item in PersonelEkle.personelListesi)
                {
                    Personel p = (Personel)item;
                    ListViewItem lst = new ListViewItem();
                    lst.Text = p.Ad;
                    lst.SubItems.Add(p.Soyad);
                    lst.SubItems.Add(p.ISeGirisTarihi.ToLongDateString());
                    lst.SubItems.Add(p.Tckn);
                    lst.SubItems.Add(p.Adres);

                    lstPersonel.Items.Add(lst);

                }
            }
            PersonelEkle.personelListesi.Clear();

        }
    }
}
