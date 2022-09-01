using Gestion.dinventaire.Backend.DAL.Config;
using Gestion.dinventaire.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dinventaire.Backend.DAL.Enteties
{
    public class APIContext : DbContext
    {

        private readonly string _cnstr;
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Equipement_materielle_electronique> Electroniques { get; set; }
        public DbSet<Equipement_materielles_physique> Physiques { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Clavier> claviers { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<ChaiseBurautique> ChaiseBurautiques { get; set; }

        public APIContext()
        {
            this._cnstr = @"Data Source=NETLAB202\TFTIC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            this._cnstr = @"Data Source=HAJERSOUSSI;Initial Catalog=DBInventaire;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public APIContext(string ConnectionString) : base()
        {
            this._cnstr = ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.UseSqlServer(_cnstr);
            optionsBuilder.UseSqlServer("BDConnection");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configuration de mes entité
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfig());
            modelBuilder.ApplyConfiguration<Table>(new TableConfig());

            modelBuilder.ApplyConfiguration<ChaiseBurautique>(new ChaiseConfig());
            modelBuilder.ApplyConfiguration<Clavier>(new ClavierConfig());
            modelBuilder.ApplyConfiguration<Computer>(new ComputerConfig());

        }
    }
}
