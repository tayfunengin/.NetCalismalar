using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFA_ETicaretDb
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

            ProductList();
           
            
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
                lvi.SubItems.Add(p.CATEGORYId.ToString());
                lvi.SubItems.Add(p.SUBCATEGORYId.ToString());
                listView1.Items.Add(lvi);
            }

        }

    }
}
