using BLL.Repository;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWinForm
{
    public partial class Form1 : Form
    {
               
        public Form1()
        {
            InitializeComponent();
        }
        MovieForm movieForm = new MovieForm();
        CategoryForm categoryForm = new CategoryForm();
        SaloonForm saloonForm = new SaloonForm();
        SessionForm sessionForm = new SessionForm();
        WeekForm weekForm = new WeekForm();
        List<Form> forms = new List<Form>();      
                
        private void Form1_Load(object sender, EventArgs e)
        {
            forms.Add(movieForm);
            forms.Add(categoryForm);
            forms.Add(saloonForm);
            forms.Add(weekForm);
            forms.Add(sessionForm);

            foreach (Form form in forms)
            {
                form.TopLevel = false;
                pnlContent.Controls.Add(form);
            }

        }
        public void ShowForm(Form form)
        {
            
            foreach (Form f in pnlContent.Controls)
            {
                f.Hide();
            }
            form.Show();
        }
        private void BtnMovie_Click(object sender, EventArgs e)
        {
            ShowForm(movieForm);            
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            ShowForm(categoryForm);
        }

        private void BtnSaloon_Click(object sender, EventArgs e)
        {
            ShowForm(saloonForm);
        }

        private void BtnSession_Click(object sender, EventArgs e)
        {
            ShowForm(sessionForm);
        }

        private void BtnWeek_Click(object sender, EventArgs e)
        {
            ShowForm(weekForm);
        }
    }

}
