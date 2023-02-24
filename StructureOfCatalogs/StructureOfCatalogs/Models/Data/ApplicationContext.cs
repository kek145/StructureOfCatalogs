using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace StructureOfCatalogs.Models.Data
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<CreatingDigitalImages> CreatingDigitalImages { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<PrimarySources> PrimarySources { get; set; }
        public DbSet<SecondarySources> SecondarySources { get; set; }
        public DbSet<Evidence> Evidence { get; set; }
        public DbSet<GraphicProducts> GraphicProducts { get; set; }
        public DbSet<Process> Process { get; set; }
        public DbSet<FinalProduct> FinalProduct { get; set; }
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BEHCHLL;Initial Catalog=StructureOfCatalogs;Integrated Security=True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreatingDigitalImages>().HasKey(key1 => key1.CreatingDigitalImagesID);
            modelBuilder.Entity<Resources>().HasKey(key2 => key2.ResourcesID);
            modelBuilder.Entity<PrimarySources>().HasKey(key3 => key3.PrimarySourcesID);
            modelBuilder.Entity<SecondarySources>().HasKey(key4 => key4.SecondarySourcesID);
            modelBuilder.Entity<Evidence>().HasKey(key5 => key5.EvidenceID);
            modelBuilder.Entity<GraphicProducts>().HasKey(key6 => key6.GraphicProductsID);
            modelBuilder.Entity<Process>().HasKey(key7 => key7.ProcessID);
            modelBuilder.Entity<FinalProduct>().HasKey(key8 => key8.FinalProductID);
        }
    }
}
