using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;
using static FitLife.GlobalConstants.DataConstants.Product;
using static FitLife.GlobalConstants.ErrorMessages;

namespace FitLife.Web.ViewModels.Product
{
    public class ProductServiceModel
    {
        [Key]
        public string Id { get; set; } = null!;

        [Required(ErrorMessage = RequiredError)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = StringLengthError)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredError)]
        [StringLength(DescriptionMaxLength,
            MinimumLength = DescriptionMinLength,
            ErrorMessage = StringLengthError)]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = RequiredError)]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredError)]
        [Range(MinPrice, MaxPrice, ErrorMessage = DurationError)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredError)]
        public bool IsAvailable { get; set; }

        public int Count { get; set; } = 1;

    }
}
