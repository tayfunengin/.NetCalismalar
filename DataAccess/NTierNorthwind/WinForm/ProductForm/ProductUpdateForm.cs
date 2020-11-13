using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL.Repositories;

namespace WinForm.ProductForm
{
    public partial class ProductUpdateForm : Form
    {
        public ProductUpdateForm()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        Repository<Category> _categoryRepository = new Repository<Category>();
        Repository<Supplier> _supplierRepository = new Repository<Supplier>();
        Repository<Product> _productRpository = new Repository<Product>();
        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = _categoryRepository.GetList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

            cmbSupplier.DataSource = _supplierRepository.GetList();
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierID";
        }

        Product updatedProduct = new Product();       
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            updatedProduct.ProductID = ProductListForm.updated.ProductID;
            updatedProduct.ProductName = txtProductName.Text;
            updatedProduct.UnitPrice = Convert.ToInt32(txtPrice.Text);
            updatedProduct.UnitsInStock =Convert.ToInt16(nudStock.Value);
            updatedProduct.CategoryID =(int)cmbCategory.SelectedValue;
            updatedProduct.SupplierID =(int)cmbSupplier.SelectedValue;

            MessageBox.Show(_productRpository.Update(updatedProduct));

        }
    }
}
