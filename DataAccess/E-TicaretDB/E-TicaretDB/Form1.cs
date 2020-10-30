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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        eTicaretDBEntities db = new eTicaretDBEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = db.PRODUCTCATEGORies.ToList();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedIndex = -1;

            ProductList();
            lblUrunAdet.Text = TotalProductCount().ToString();
            lblStokAdet.Text = TotalStock().ToString();
        }

        public void ProductList()
        {
            listView1.Items.Clear();
            foreach (PRODUCT p in db.PRODUCTS.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.ID.ToString();
                lvi.SubItems.Add(p.PRODUCTCODE);
                lvi.SubItems.Add(p.PRODUCTNAME);
                lvi.SubItems.Add(p.PRICE.ToString());
                lvi.SubItems.Add(p.STOCK.ToString());
                lvi.SubItems.Add(p.CATEGORYId.ToString());
                listView1.Items.Add(lvi);
            }
        }

        public void ProductList(string value)
        {
            listView1.Items.Clear();
            foreach (PRODUCT p in db.PRODUCTS.Where(x=>x.PRODUCTNAME.StartsWith(value)).ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.ID.ToString();
                lvi.SubItems.Add(p.PRODUCTCODE);
                lvi.SubItems.Add(p.PRODUCTNAME);
                lvi.SubItems.Add(p.PRICE.ToString());
                lvi.SubItems.Add(p.STOCK.ToString());
                lvi.SubItems.Add(p.CATEGORYId.ToString());
                listView1.Items.Add(lvi);
            }
        }

        public int TotalProductCount()
        {
            int totalProduct = listView1.Items.Count;
            return totalProduct;
        }

        public int TotalStock()
        {
            int totalStock =(int) db.PRODUCTS.Sum(x => x.STOCK);
            return totalStock;
        }

        public void OrderByProductList()
        {
            listView1.Items.Clear();
            foreach (PRODUCT p in db.PRODUCTS.OrderBy(x=>x.PRICE))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.ID.ToString();
                lvi.SubItems.Add(p.PRODUCTCODE);
                lvi.SubItems.Add(p.PRODUCTNAME);
                lvi.SubItems.Add(p.PRICE.ToString());
                lvi.SubItems.Add(p.STOCK.ToString());
                lvi.SubItems.Add(p.CATEGORYId.ToString());
                listView1.Items.Add(lvi);
            }

        }
        public void OrderByDescProductList()
        {
            listView1.Items.Clear();
            foreach (PRODUCT p in db.PRODUCTS.OrderByDescending(x => x.PRICE))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.ID.ToString();
                lvi.SubItems.Add(p.PRODUCTCODE);
                lvi.SubItems.Add(p.PRODUCTNAME);
                lvi.SubItems.Add(p.PRICE.ToString());
                lvi.SubItems.Add(p.STOCK.ToString());
                lvi.SubItems.Add(p.CATEGORYId.ToString());
                listView1.Items.Add(lvi);
            }

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            OrderByProductList();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OrderByDescProductList();
        }

        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            ProductList(txtAra.Text);
        }

        private void BtnUrunKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                PRODUCT newProduct = new PRODUCT();
                newProduct.PRODUCTCODE = txtUrunKodu.Text;
                newProduct.PRODUCTNAME = txtUrunAd.Text;
                newProduct.PRICE = (double)nudFiyat.Value;
                newProduct.STOCK = (int)nudStokMiktar.Value;
                newProduct.CATEGORYId = (int)cmbKategori.SelectedValue;
                db.PRODUCTS.Add(newProduct);
                db.SaveChanges();
                MessageBox.Show($"{newProduct.PRODUCTNAME} kaydedildi");
                ProductList();
            }
            catch (Exception ex)
            {

               MessageBox.Show( ex.Message );
            }         
            
        }

        private void BtnKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriForm kategoriForm = new KategoriForm();            
            kategoriForm.Show();
            this.Hide();
        }
    }
}
