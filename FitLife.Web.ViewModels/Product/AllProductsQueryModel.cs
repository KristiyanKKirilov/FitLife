using FitLife.Data.Models.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace FitLife.Web.ViewModels.Product
{
    public class AllProductsQueryModel
    {
        public AllProductsQueryModel()
        {
            Products = new List<ProductServiceModel>();
        }

        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; } = null!;

        public ProductSorting Sorting { get; set; }
        public int TotalProductsCount { get; set; }

        public IEnumerable<ProductServiceModel> Products { get; set; }
    }
}
