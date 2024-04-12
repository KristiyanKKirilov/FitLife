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
                    Price = 12m,
                    IsAvailable = true,
                    AvailableStockCount = 100,
                    Count = 1,
                    
                }
            };
        }
    }
}
