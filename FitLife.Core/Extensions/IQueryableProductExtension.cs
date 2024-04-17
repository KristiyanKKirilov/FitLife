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

		public static ProductServiceModel ProjectToProductServiceModel(this Product products)
		{
			return new ProductServiceModel()
				{
					Id = products.Id,
					ImageUrl = products.ImageUrl,
					Description = products.Description,
					IsAvailable = products.IsAvailable,
					Name = products.Name,
					Price = products.Price                    
				};
		}

		public static IQueryable<ProductServiceModel> ProjectToProductServiceModel(this IQueryable<ParticipantProduct> products)
		{
			return products
				.Select(p => new ProductServiceModel()
				{
					Id = p.Id,
					ImageUrl = p.Product.ImageUrl,
					Description = p.Product.Description,
					IsAvailable = p.Product.IsAvailable,
					Name = p.Product.Name,
					Price = p.Product.Price
				});
		}


	}
}
