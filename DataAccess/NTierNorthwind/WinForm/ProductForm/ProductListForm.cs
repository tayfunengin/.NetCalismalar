using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Repositories;
using DAL;

namespace WinForm.ProductForm
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        Repository<Product> _productRepository = new Repository<Product>();
        private void ProductListForm_Load(object sender, EventArgs e)
        {
            GetProducts();
        }

        public void GetProducts()
        {
            listView1.Items.Clear();
            foreach (Product p in _productRepository.GetList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.ProductID.ToString();
                lvi.SubItems.Add(p.ProductName);
                lvi.SubItems.Add(p.UnitPrice.ToString());
                lvi.SubItems.Add(p.UnitsInStock.ToString());
                string catName = db.Categories.FirstOrDefault(x => x.CategoryID == p.CategoryID).CategoryName;
                lvi.SubItems.Add(catName);
              //  lvi.SubItems.Add(p.Category.CategoryName);
              
               string supName = db.Suppliers.FirstOrDefault(x => x.SupplierID == p.SupplierID).CompanyName;

                lvi.SubItems.Add(supName);
                lvi.Tag = p;
                listView1.Items.Add(lvi);
            }
        }

        private void TxtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            FindByName(txtSearchProduct.Text);
        }

        public void FindByName(string param)
        {
            listView1.Items.Clear();
            foreach (Product p in _productRepository.GetDefault(x => x.ProductName.StartsWith(param)))            
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.ProductID.ToString();
                lvi.SubItems.Add(p.ProductName);
                lvi.SubItems.Add(p.UnitPrice.ToString());
                lvi.SubItems.Add(p.UnitsInStock.ToString());
                //  lvi.SubItems.Add(p.Category.CategoryName);  
                string catName = db.Categories.FirstOrDefault(x => x.CategoryID == p.CategoryID).CategoryName;                            
                lvi.SubItems.Add(catName);

                string supName = db.Suppliers.FirstOrDefault(x => x.SupplierID == p.SupplierID).CompanyName;
                lvi.SubItems.Add(supName);

                listView1.Items.Add(lvi);
            }
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            // hata veriyor
            int id = Convert.ToInt32(listView1.SelectedItems[0].Text);
            MessageBox.Show(_productRepository.Delete(id));
        }

       public static Product updated;
        private void BtnUpdateProduct_Click(object sender, EventArgs e)
        {
            ProductUpdateForm puf = new ProductUpdateForm();
            puf.Show();

            // updated a atama yapmıyor
            updated = listView1.SelectedItems[0].Tag as Product;

            foreach (Control ctrl in puf.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    if (txt.Name == "txtProductName")
                    {                        
                        txt.Text = updated.ProductName;
                    }
                    else if(txt.Name=="txtPrice")
                    {
                        txt.Text = updated.UnitPrice.ToString();
                    }
                   
                }

                if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;                   
                    nud.Value = Convert.ToDecimal(updated.UnitsInStock);                    
                }
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    if (cmb.Name == "cmbCategory")
                    {
                        cmb.SelectedValue = updated.Category.CategoryID;

                    }
                    else if (cmb.Name == "cmbSupplier") 
                    {
                        cmb.SelectedValue = updated.SupplierID;
                    }
                }

            }

        }
    }
}
