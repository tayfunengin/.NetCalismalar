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
        }

        public void ProductList()
        {
            foreach (PRODUCT p in db.PRODUCTS)
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

    }
}
