using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_Projekt.Model.DbContexts
{
    public class ProjectManagementDataContext : DbContext
    {
        public ProjectManagementDataContext()
        {
        }

        public ProjectManagementDataContext(DbContextOptions<ProjectManagementDataContext> options) : base(options)
        {
        }

        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<Dzial> Dzialy { get; set; }
        public DbSet<Zespol> Zespoly { get; set; }
        public DbSet<Biuro> Biura { get; set; }
        public DbSet<Projekt> Projekty { get; set; }
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Wspolpraca> Wspolprace { get; set; }
        public DbSet<Podwykonawca> Podwykonawcy { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
            }
        }
    }
}
