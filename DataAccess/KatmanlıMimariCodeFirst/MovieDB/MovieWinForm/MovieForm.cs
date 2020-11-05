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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }
        BaseRepository<Movie> _movieRepository = new BaseRepository<Movie>();
        private void MovieForm_Load(object sender, EventArgs e)
        {
            GetListMovies();
        }
        public void GetListMovies()
        {
            foreach (Movie movie in _movieRepository.GetList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = movie.ID.ToString();
                lvi.SubItems.Add(movie.MovieName);
                lvi.SubItems.Add(movie.Description);
                lvi.SubItems.Add(movie.Duration.ToString());
                lvi.SubItems.Add(movie.Rank.ToString());
                lvi.Tag = movie;
                listView1.Items.Add(lvi);

            }


        }
    }
}
