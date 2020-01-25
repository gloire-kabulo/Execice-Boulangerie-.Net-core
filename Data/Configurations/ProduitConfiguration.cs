using Boulangerie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boulangerie.Data.Configurations
{
    public class ProduitConfiguration:IEntityTypeConfiguration<Produit>{
        public void Configure(EntityTypeBuilder<Produit> builder){
            builder.Property(p => p.NomImage).HasColumnName("ImageFileName");
        }
    }
}