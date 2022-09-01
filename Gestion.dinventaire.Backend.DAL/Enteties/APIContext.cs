using Gestion.dinventaire.Backend.DAL.Config;

using Gestion.dinventaire.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;


namespace Gestion.dinventaire.Backend.DAL.Enteties
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions options) : base(options)
        {
            
                Employees = Set<Employee>();
                Tables = Set<Table>();
                claviers = Set<Clavier>();
                Computers = Set<Computer>();
                ChaiseBurautiques = Set<ChaiseBurautique>();
                //equipement_Materielle_Physiques=Set<Equipement_materielle_physique>();
                //equipement_Materielle_Electroniques = Set<Equipement_materielle_electronique>();

                
            

        }


        //private readonly string _cnstr;
        public DbSet<Employee>? Employees { get; set; }
        
        public DbSet<Table>? Tables { get; set; }
        public DbSet<Clavier>? claviers { get; set; }
        public DbSet<Computer>? Computers { get; set; }
        public DbSet<ChaiseBurautique>? ChaiseBurautiques { get; set; }
        //public DbSet<Equipement_materielle_electronique>? equipement_Materielle_Electroniques { get; set; }
        //   public DbSet<Equipement_materielle_physique>? equipement_Materielle_Physiques { get; set; }


        //public APIContext()
        //{
        //    this._cnstr = @"Data Source=NETLAB202\TFTIC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //    this._cnstr = @"Data Source=HAJERSOUSSI;Initial Catalog=DBInventaire;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //}

        //public APIContext(string ConnectionString) : base()
        //{
        //    this._cnstr = ConnectionString;
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableDetailedErrors();
            if (!optionsBuilder.IsConfigured)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    string csbuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build().GetConnectionString("DBConnection").ToString();

                    optionsBuilder.UseSqlServer(csbuilder);
                }
            }
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.EnableDetailedErrors();
        //    //optionsBuilder.UseSqlServer(_cnstr);
        //    optionsBuilder.UseSqlServer("DBConnection");

        //    base.OnConfiguring(optionsBuilder);
        //}

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
