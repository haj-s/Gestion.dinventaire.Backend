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
            
                Employees = Set<EmployeeEntity>();
                Tables = Set<TableEntity>();
                claviers = Set<ClavierEntity>();
                Computers = Set<ComputerEntity>();
                ChaiseBurautiques = Set<ChaiseBurautiqueEntity>();
                //equipement_Materielle_Physiques=Set<Equipement_materielle_physique>();
                //equipement_Materielle_Electroniques = Set<Equipement_materielle_electronique>();

                
            

        }


        //private readonly string _cnstr;
        public DbSet<EmployeeEntity> Employees { get; set; }
        
        public DbSet<TableEntity> Tables { get; set; }
        public DbSet<ClavierEntity> claviers { get; set; }
        public DbSet<ComputerEntity> Computers { get; set; }
        public DbSet<ChaiseBurautiqueEntity> ChaiseBurautiques { get; set; }
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
            modelBuilder.ApplyConfiguration<EmployeeEntity>(new EmployeeConfig());
            modelBuilder.ApplyConfiguration<TableEntity>(new TableConfig());

            modelBuilder.ApplyConfiguration<ChaiseBurautiqueEntity>(new ChaiseConfig());
            modelBuilder.ApplyConfiguration<ClavierEntity>(new ClavierConfig());
            modelBuilder.ApplyConfiguration<ComputerEntity>(new ComputerConfig());

        }
    }
}
