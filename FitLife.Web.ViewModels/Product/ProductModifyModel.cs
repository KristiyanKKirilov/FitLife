using FitLife.Data.Models.Enumerations;

namespace FitLife.Web.ViewModels.Product
{
    public class ProductModifyModel : ProductFormModel
    {
        public string Id { get; set; } = null!;

        public AvailableOptions IsAvailable { get; set; }
    }
}
