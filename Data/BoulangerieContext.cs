using Boulangerie.Models;
using Microsoft.EntityFrameworkCore;
using Boulangerie.Data.Configurations;
 
namespace Boulangerie.Data
{
    public class BoulangerieContext:DbContext{
        public DbSet<Produit> Produits{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite(@"Data source = Boulangerie.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new ProduitConfiguration()).Seed();
        }
    }
}