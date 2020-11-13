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

namespace WinForm.CategoryForm
{
    public partial class CategoriAddForm : Form
    {
        public CategoriAddForm()
        {
            InitializeComponent();
        }

        Repository<Category> _categoryRepository = new Repository<Category>();
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category();
            newCategory.CategoryName = txtCategoryName.Text;
            newCategory.Description = txtCategoryDesc.Text;
           MessageBox.Show( _categoryRepository.Add(newCategory));
        }

    }
}
