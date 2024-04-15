using FitLife.Data.Models.Enumerations;
using FitLife.Web.ViewModels.Product;

namespace FitLife.Core.Contracts
{
    public interface IProductService
    {
        Task<ProductQueryServiceModel> AllAsync(
            string? searchTerm = null,
            ProductSorting sorting = ProductSorting.PriceAscending);
    }
}
