using Boulangerie.Models;
using Microsoft.EntityFrameworkCore;

namespace Boulangerie.Data
{
    public static class ModelBuilderExtensions{
        public static ModelBuilder Seed(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Produit>().HasData(
                new Produit
                {
                    Id = 1,
                    Nom = "Carrot Cake",
                    Description = "Un délicieux gâteau mini-carotte incrusté d' amandes tranchées",
                    Prix = 8.99m,
                    NomImage = "carrot_cake.jpg"
                },
                new Produit
                {
                    Id = 2,
                    Nom = "Lemon Tart",
                    Description = "Une tarte au citron délicieuse avec la meringue fraîche cuite à la perfection",
                    Prix = 9.99m,
                    NomImage = "lemon_tart.jpg"
                },
                new Produit
                {
                    Id = 3,
                    Nom = "Cupcakes",
                    Description = "Cuvets de vanille et de chocolat suppressibles",
                    Prix = 5.99m,
                    NomImage = "cupcakes.jpg"
                },
                new Produit
                {
                    Id = 4,
                    Nom = "Bread",
                    Description = "Pain de style français frais",
                    Prix = 1.49m,
                    NomImage = "bread.jpg"
                },
                new Produit
                {
                    Id = 5,
                    Nom = "Pear Tart",
                    Description = "Une tarte à la poire vitrée surmontée d' amandes tranchées et d' un soupçon de cannil",
                    Prix = 5.99m,
                    NomImage = "pear_tart.jpg"
                },
                new Produit
                {
                    Id = 6,
                    Nom = "Chocolate Cake",
                    Description = "Le glaçage au chocolat riche couvre le rêve de ce amateur de chocolat",
                    Prix = 8.99m,
                    NomImage = "chocolate_cake.jpg"
                }
            );
            return modelBuilder;
        }
    }
}