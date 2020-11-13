using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.CategoryForm;
using WinForm.ProductForm;

namespace WinForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void KategoriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ChildForm(new CategoryListForm());
        }
        private void ÜrünListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildForm(new ProductListForm());
        }
        private void ÜrünListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new CategoriAddForm());
        }

        public void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width;
            this.Height = _childForm.Height;


            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }
      
    }
}
