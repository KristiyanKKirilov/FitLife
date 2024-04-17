namespace FitLife.Web.ViewModels.Product
{
    public class ProductQueryServiceModel
    {
        public ProductQueryServiceModel()
        {
            Products = new List<ProductServiceModel>();
        }
        public int TotalProductsCount { get; set; }

        public IEnumerable<ProductServiceModel> Products { get; set; }
    }
}
