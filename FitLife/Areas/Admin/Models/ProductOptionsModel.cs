using FitLife.Web.ViewModels.Product;

namespace FitLife.Web.Areas.Admin.Models
{
	public class ProductOptionsModel
	{
        public ProductOptionsModel()
        {
            Products = new HashSet<ProductServiceModel>();
        }
        
        public IEnumerable<ProductServiceModel> Products { get; set; }

    }
}
