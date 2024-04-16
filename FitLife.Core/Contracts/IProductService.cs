using FitLife.Data.Models.Enumerations;
using FitLife.Web.ViewModels.Product;

namespace FitLife.Core.Contracts
{
	public interface IProductService
    {
        Task<ProductQueryServiceModel> AllAsync(
            string? searchTerm = null,
            ProductSorting sorting = ProductSorting.PriceAscending);
        Task<bool> ExistsAsync(string productId);
        Task<ProductDetailsServiceModel> ProductDetailsByIdAsync(string productId);

        Task<string> CreateAsync(ProductFormModel model);

        Task<string> GetProductIdByNameAsync(string productName);

        Task<IEnumerable<string>> GetAllProductsNamesAsync();
        Task<ProductModifyModel?> GetProductModifyModelByIdAsync(string productId);
    }
}
