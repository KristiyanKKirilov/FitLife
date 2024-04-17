using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;
using static FitLife.GlobalConstants.ErrorMessages;


namespace FitLife.Web.ViewModels.Event
{
	public class EventServiceModel
	{
		[Key]
		public string Id { get; set; } = null!;

		[Required(ErrorMessage = RequiredError)]
		[StringLength(TitleMaxLength,
			 MinimumLength = TitleMinLength,
			ErrorMessage = StringLengthError)]
		public string Title { get; set; } = null!;

		[Required(ErrorMessage = RequiredError)]
		public string ImageUrl { get; set; } = null!;

		[Required(ErrorMessage = RequiredError)]
		public DateTime StartTime { get; set; }

		[Required(ErrorMessage = RequiredError)]
		public string Address { get; set; } = null!;

		[Required(ErrorMessage = RequiredError)]
		public string City { get; set; } = null!;

        [Required(ErrorMessage = RequiredError)]
		[Display(Name = "Category")]
		public string CategoryName { get; set; } = null!;

		[Required(ErrorMessage = RequiredError)]
		[Display(Name = "Trainer")]
		public string CreatorName { get; set; } = null!;
	}
}
