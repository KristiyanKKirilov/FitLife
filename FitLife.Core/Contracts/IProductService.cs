using FitLife.Data.Models.Enumerations;
using FitLife.Web.ViewModels.Event;
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
    }
}
