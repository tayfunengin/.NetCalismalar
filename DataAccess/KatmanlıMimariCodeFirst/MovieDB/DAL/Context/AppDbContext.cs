using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
   public class AppDbContext : DbContext
    {

        public AppDbContext()
        {
            Database.Connection.ConnectionString =
                "server =.; database = MovieTheaterDBKatmanli; integrated security = True";
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<Theater> Theaters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
