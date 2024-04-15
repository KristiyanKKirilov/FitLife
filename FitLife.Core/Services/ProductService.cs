using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.Data.Models.Enumerations;
using FitLife.Web.ViewModels.Event;
using FitLife.Web.ViewModels.Product;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repository;

        public ProductService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<ProductQueryServiceModel> AllAsync(string? searchTerm = null, ProductSorting sorting = ProductSorting.PriceAscending)
        {
            var productsToShow = repository.AllReadOnly<Product>();            

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();

                productsToShow = productsToShow
                    .Where(e => e.Name.ToLower().Contains(normalizedSearchTerm)
                            || e.Description.ToLower().Contains(normalizedSearchTerm));
            }

            productsToShow = sorting switch
            {
                ProductSorting.PriceDescending => productsToShow
                    .OrderByDescending(p => p.Price),                
                _ => productsToShow
                .OrderBy(h => h.Price)
            };

            var products = await productsToShow
               .ProjectToProductServiceModel()
               .ToListAsync();

            int totalProducts = await productsToShow.CountAsync();           

            return new ProductQueryServiceModel()
            {
                TotalProductsCount = totalProducts,
                Products = products
            };
        }
    }
}
