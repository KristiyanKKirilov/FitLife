using FitLife.Data.Models.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace FitLife.Web.ViewModels.Event
{
	public class AllEventsQueryModel
	{
		public AllEventsQueryModel()
		{
			Events = new List<EventServiceModel>();
		}

		public string Category { get; set; } = null!;

		[Display(Name = "Search by text")]
		public string SearchTerm { get; set; } = null!;

        public EventSorting Sorting { get; set; }
        public int EventsPerPage { get; } = 6;

		public int CurrentPage { get; init; } = 1;

		public int TotalEventsCount { get; set; }
		public IEnumerable<string> Categories { get; set; } = null!;

        public IEnumerable<EventServiceModel> Events { get; set; }




	}
}
