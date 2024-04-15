using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(SeedProducts());
        }

        private Product[] SeedProducts()
        {
            return new Product[]
            {
                new Product()
                {
                    Id = "eea12856-c198-4129-b3f3-b893d8395022",
                    Name = "Protein cookie",
                    Description = "30g of protein, 230 calories",
                    ImageUrl = "https://www.wellplated.com/wp-content/uploads/2018/04/Peanut-Butter-Protein-Cookies.jpg",
                    Price = 3.20m,
                    IsAvailable = true,
                    AvailableStockCount = 250,
                    Count = 1,
                   
                },
                new Product()
                {
                    Id = "dea12856-c198-4129-b3f3-b803d8395022",
                    Name = "Sugarfree chocolate",
                    Description = "Ideal for diets, 0% sugar, 30 calories per 100g",
                    ImageUrl = "https://cdn.shopify.com/s/files/1/2090/1141/files/bepure-perfect-plant-protein-chocolate-flavour-600g-jar_3125x.png?v=1690512984",
                    Price = 12m,
                    IsAvailable = true,
                    AvailableStockCount = 100,
                    Count = 1,
                    
                },
                new Product()
                {
                    Id = "d2a12856-c198-4129-b3f3-b803d8395022",
                    Name = "Strawberry smoothie",
                    Description = "Refreshing drink, 100% natural flavour, 0% sugar, 230 calories",
                    ImageUrl = "https://smartymockups.com/wp-content/uploads/2019/05/Smoothie_Bottle_Mockup_2.jpg",
                    Price = 7m,
                    IsAvailable = true,
                    AvailableStockCount = 50,
                    Count = 1,

                }
            };
        }
    }
}
