namespace FitLife.Web.Areas.Admin.Models
{
	public class ProductOptionsModel
	{
        public ProductOptionsModel()
        {
			ProductNames = new List<string>();
        }
        public string Name { get; set; } = null!;
        public IEnumerable<string> ProductNames { get; set; }

    }
}
