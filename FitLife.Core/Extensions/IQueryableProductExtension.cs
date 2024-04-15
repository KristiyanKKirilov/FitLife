using FitLife.Data.Models;
using FitLife.Web.ViewModels.Product;

namespace System.Linq
{
    public static class IQueryableProductExtension
    {
        public static IQueryable<ProductServiceModel> ProjectToProductServiceModel(this IQueryable<Product> products)
        {
            return products
                .Select(p => new ProductServiceModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Description = p.Description,                   
                    IsAvailable = p.IsAvailable,
                    Name = p.Name,
                    Price = p.Price
                });
        }
    }
}
