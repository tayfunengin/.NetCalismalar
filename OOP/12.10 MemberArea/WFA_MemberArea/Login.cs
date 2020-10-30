using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MemberArea
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        List<Kullanici> kullaniciListesi = new List<Kullanici>();
        private void Login_Load(object sender, EventArgs e)
        {
            Kullanici kullanici1 = new Kullanici();

            kullanici1.KullaniciAdi = "admin";
            kullanici1.Sifre = "1234";
            kullanici1.Rol = Rol.Admin;

            Kullanici kullanici2 = new Kullanici();
            kullanici2.KullaniciAdi = "user";
            kullanici2.Sifre = "123";
            kullanici2.Rol = Rol.User;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {

            foreach (Kullanici k in kullaniciListesi)
            {
                if (k.KullaniciAdi == txtKullaniciAdi.Text.ToLower() && k.Sifre == txtSifre.Text)
                {                   
                        PersonelForm personelForm = new PersonelForm();
                        personelForm.Show();
                        this.Hide();                   
                        if(k.Rol == Rol.User)
                    {
                        foreach (Control item in personelForm.Controls)
                        {
                            if(item is Button)
                            {
                                Button btn = (Button)item;
                                btn.Visible = false;
                            }
                            
                        }
                    }                   
                                              
                }
                else
                {
                    lblHata.Text = "Kullanici adi ya da şifre yanlış";
                }
            }
        }
    }
}
