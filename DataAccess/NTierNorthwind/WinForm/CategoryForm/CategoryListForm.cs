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
using BLL.Service;
using BLL.Repositories;

namespace WinForm.CategoryForm
{
    public partial class CategoryListForm : Form
    {
        public CategoryListForm()
        {
            InitializeComponent();
        }
        //CategoryService categoryService = new CategoryService();
        Repository<Category> _categoryRepository = new Repository<Category>();
        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            GetCategories();
        }
        public void GetCategories()
        {
            listView1.Items.Clear();
            foreach (Category c in _categoryRepository.GetList())
            {
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = c.CategoryID.ToString();
                lvi.SubItems.Add(c.CategoryName);
                lvi.SubItems.Add(c.Description);
                lvi.Tag = c;
                listView1.Items.Add(lvi);
            }
        }

        private void TxtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            FindByName(txtSearchCategory.Text);
        }

        public void FindByName(string param)
        {
            listView1.Items.Clear();
            foreach (Category c in _categoryRepository.GetDefault(x=>x.CategoryName.Contains(param)))
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = c.CategoryID.ToString();
                lvi.SubItems.Add(c.CategoryName);
                lvi.SubItems.Add(c.Description);
                lvi.Tag = c;
                listView1.Items.Add(lvi);
            }

        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(listView1.SelectedItems[0].Text);

            MessageBox.Show( _categoryRepository.Delete(id));
        }

       public static Category updated;
        private void BtnUpdateCategory_Click(object sender, EventArgs e)
        {
            CategoryUpdateForm cuf = new CategoryUpdateForm();
            cuf.Show();
            
            updated = listView1.SelectedItems[0].Tag as Category;                      

            foreach (Control ctrl in cuf.Controls)
            {
                if (ctrl is GroupBox)
                {
                    foreach (Control item in ctrl.Controls)
                    {
                        if (item is TextBox)
                        {
                            TextBox txt = (TextBox)item;
                            if (txt.Name == "txtCategoryName")
                            {
                                txt.Text= updated.CategoryName;
                            }
                            else if(txt.Name=="txtCategoryDesc")
                            {
                                 txt.Text= updated.Description;
                            }
                        }
                    }
                }
            }          
        
        }

       



    }
}
