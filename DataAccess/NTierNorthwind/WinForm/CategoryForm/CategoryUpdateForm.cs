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
    public partial class CategoryUpdateForm : Form
    {
      
        public CategoryUpdateForm()
        {
           
            InitializeComponent();
        }
        
     
        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {

        }
       
        Repository<Category> _categoryRepository = new Repository<Category>();
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {                       
         
            Category categoryyeni = new Category();
            categoryyeni.CategoryID = CategoryListForm.updated.CategoryID;
            categoryyeni.CategoryName = txtCategoryName.Text;
            categoryyeni.Description = txtCategoryDesc.Text;

            MessageBox.Show(_categoryRepository.Update(categoryyeni)); 
        }
    }
}
