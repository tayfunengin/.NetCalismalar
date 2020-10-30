using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_TicaretDB
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        eTicaretDBEntities db = new eTicaretDBEntities();
        private void BtnKategoriEkle_Click(object sender, EventArgs e)
        {
            PRODUCTCATEGORY newCategory = new PRODUCTCATEGORY();

            newCategory.CATEGORYNAME = txtKategoriAd.Text;
            db.PRODUCTCATEGORies.Add(newCategory);

            if (db.SaveChanges() > 0)
                MessageBox.Show($"{newCategory.CATEGORYNAME} eklendi");
            else
                MessageBox.Show("Bir hata meydana geldi");
            txtKategoriAd.Text = "";

            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
