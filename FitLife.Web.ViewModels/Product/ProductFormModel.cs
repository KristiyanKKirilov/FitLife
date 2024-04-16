using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;
using static FitLife.GlobalConstants.ErrorMessages;
using static FitLife.GlobalConstants.DataConstants.Product;
using FitLife.Data.Models.Enumerations;

namespace FitLife.Web.ViewModels.Product
{
	public class ProductFormModel
	{
		[Required]
		[StringLength(NameMaxLength,
			MinimumLength = NameMinLength,
			ErrorMessage = StringLengthError)]
		public string Name { get; set; } = null!;

		[Required]
		[StringLength(DescriptionMaxLength,
			MinimumLength = DescriptionMinLength,
			ErrorMessage = StringLengthError)]
		public string Description { get; set; } = null!;

		[Required]
		[Display(Name = "Image Url")]
		public string ImageUrl { get; set; } = null!;

		[Required]
		[Range(MinPrice, MaxPrice, ErrorMessage = DurationError)]
		public decimal Price { get; set; }	

		[Required]
		[Range(MinStock, MaxStock, ErrorMessage = DurationError)]
		[Display(Name = "Available product's count")]
		public int AvailableStockCount { get; set; }

		[Required]
		[Display(Name = "Fixed product's count")]
		public int Count { get; set; }

	}
}
