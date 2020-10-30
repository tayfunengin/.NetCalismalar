using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MuzisyenEkle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<MuzikAleti> muzikAletiListesi = new List<MuzikAleti>();

        private void Form1_Load(object sender, EventArgs e)
        {

            Bateri bateri = new Bateri();
            bateri.Marka = "Yamaha";

            Gitar gitar = new Gitar();
            gitar.Marka = "Gibson";

            muzikAletiListesi.Add(bateri);
            muzikAletiListesi.Add(gitar);

            Muzisyen muzisyen1 = new Muzisyen();
            muzisyen1.Ad = "Tayfun";
            muzisyen1.CaldigiEnstruman = bateri;

            Muzisyen muzisyen2 = new Muzisyen();
            muzisyen1.Ad = "Engin";
            muzisyen1.CaldigiEnstruman = gitar;

            foreach (MuzikAleti item in muzikAletiListesi)
            {
                if (item is Bateri)
                {
                    Bateri b = (Bateri)item;
                    cmbEnstruman.Items.Add(b);
                }
                else if (item is Gitar)
                {
                    Gitar g = (Gitar)item;
                    cmbEnstruman.Items.Add(g);
                }
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lst = new ListViewItem();
            lst.Text = txtAd.Text;
            lst.SubItems.Add(txtSoyad.Text);
            lst.SubItems.Add(cmbEnstruman.Text);
            listView1.Items.Add(lst);
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.SelectedItems[i].SubItems[2].Text == "Bateri")
                {
                    Bateri b = new Bateri();
                    MessageBox.Show(b.Cal());
                }
                else if (listView1.SelectedItems[i].SubItems[2].Text == "Gitar")
                {
                    Gitar g = new Gitar();
                    MessageBox.Show(g.Cal());
                }
            }
        }
    }
}
