using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;
using static FitLife.GlobalConstants.DataConstants.Event;
using static FitLife.GlobalConstants.ErrorMessages;

namespace FitLife.Web.ViewModels.Event
{
	public class EventFormModel
	{
		public EventFormModel()
		{
			EventCategories = new HashSet<EventCategoryServiceModel>();
		}

		/// <summary>
		/// Event's title
		/// </summary>
		[Required(ErrorMessage = RequiredError)]
		[StringLength(TitleMaxLength,
			MinimumLength = TitleMinLength,
			ErrorMessage = StringLengthError)]
		public string Title { get; set; } = null!;

		/// <summary>
		/// Event's description
		/// </summary>
		[Required(ErrorMessage = RequiredError)]
		[StringLength(DescriptionMaxLength,
			MinimumLength = DescriptionMinLength,
			ErrorMessage = StringLengthError)]
		public string Description { get; set; } = null!;

		/// <summary>
		/// Event's address
		/// </summary>
		[Required(ErrorMessage = RequiredError)]
		[StringLength(AddressMaxLength,
			MinimumLength = AddressMinLength,
			ErrorMessage = StringLengthError)]
		public string Address { get; set; } = null!;

		/// <summary>
		/// Event's image url
		/// </summary>
		[Required(ErrorMessage = RequiredError)]
		public string ImageUrl { get; set; } = null!;

		/// <summary>
		/// Event's date of start in format dd/MM/yyyy hh:mm
		/// </summary>
		[Required(ErrorMessage = RequiredError)]
		[Display(Name = "Start time")]
		public string StartTime { get; set; } = null!;

		/// <summary>
		/// Event's duration in days
		/// </summary>
		[Required(ErrorMessage = RequiredError)]
		[StringLength(CityMaxLength, MinimumLength = CityMinLength, ErrorMessage = StringLengthError)]
		public string City { get; set; } = null!;

		/// <summary>
		/// Event's category identifier
		/// </summary>
		[Required(ErrorMessage = RequiredError)]
		[Display(Name = "Category")]
		public int CategoryId { get; set; }

		public IEnumerable<EventCategoryServiceModel> EventCategories { get; set; }
	}
}
