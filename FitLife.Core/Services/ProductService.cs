using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.Data.Models.Enumerations;
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

        public async Task AddToCartAsync(string productId, string userId)
        {
            var product = await repository
                        .GetByIdAsync<Product>(productId);

            var user = await repository
                .GetByIdAsync<Participant>(userId);
          
            
            if (product != null && user != null)
            {
                var participantProduct = new ParticipantProduct()
                {
                    ParticipantId = userId,
                    ProductId = productId

                };
                await repository.AddAsync(participantProduct);
				await repository.SaveChangesAsync();

			}

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

        public async Task<IEnumerable<ProductServiceModel>> AllAsync()
        {
            return await repository
                .AllReadOnly<Product>()
                .ProjectToProductServiceModel()
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductServiceModel>> AllProductsByParticipantAsync(string participantId)
        {
            return await repository
                .AllReadOnly<ParticipantProduct>()
                .Where(p => p.Participant.Id == participantId)
                .ProjectToProductServiceModel()
                .ToListAsync();
        }      

        public async Task<string> CreateAsync(ProductFormModel model)
        {
            var newProduct = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                AvailableStockCount = model.AvailableStockCount,
                Count = model.Count,
                ImageUrl = model.ImageUrl,
                IsAvailable = true,
                Price = model.Price
            };

            await repository.AddAsync(newProduct);
            await repository.SaveChangesAsync();

            return newProduct.Id;
        }

        public async Task DeleteAsync(string productId)
        {
            var product = await repository
                 .GetByIdAsync<Product>(productId);

            if (product != null)
            {
                repository.Remove(product);
                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(string productId)
        {
            return await repository
                .AllReadOnly<Product>()
                .AnyAsync(p => p.Id == productId);
        }

        public async Task<IEnumerable<string>> GetAllProductsNamesAsync()
        {
            return await repository
                .AllReadOnly<Product>()
                .Select(p => p.Name)
                .ToListAsync();
        }

        public async Task<string> GetProductIdByNameAsync(string productName)
        {
            var product = await repository
                .AllReadOnly<Product>()
                .Where(p => p.Name.ToLower() == productName.ToLower())
                .FirstOrDefaultAsync();

            if (product == null)
            {
                throw new Exception();
            }

            return product.Id;
        }

        public async Task<ProductModifyModel?> GetProductModifyModelByIdAsync(string productId)
        {
            var currentProduct = await repository
                .AllReadOnly<Product>()
                .Where(p => p.Id == productId)
                .Select(p => new ProductModifyModel()
                {
                    Id = p.Id,
                    Price = p.Price,
                    AvailableStockCount = p.AvailableStockCount,
                    Count = p.Count,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    Description = p.Description
                }).FirstOrDefaultAsync();

            return currentProduct;
        }

        public async Task ModifyAsync(string productId, ProductModifyModel model)
        {
            var product = await repository
                .GetByIdAsync<Product>(productId);

            if (product != null)
            {
                product.Name = model.Name;
                product.Price = model.Price;
                product.Description = model.Description;
                product.AvailableStockCount = model.AvailableStockCount;
                product.Count = model.Count;
                product.IsAvailable = Convert.ToBoolean((int)model.IsAvailable);
                product.ImageUrl = model.ImageUrl;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<ProductDetailsServiceModel> ProductDetailsByIdAsync(string productId)
        {
            return await repository
                .AllReadOnly<Product>()
                .Where(p => p.Id == productId)
                .Select(p => new ProductDetailsServiceModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    Description = p.Description,
                    IsAvailable = p.IsAvailable,
                    Price = p.Price
                }).FirstAsync();
        }


    }
}
