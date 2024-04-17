namespace FitLife.Web.ViewModels.Event
{
	public class EventQueryServiceModel
	{
		public EventQueryServiceModel()
		{
			Events = new List<EventServiceModel>();
		}
		public int TotalEventsCount { get; set; }

		public IEnumerable<EventServiceModel> Events { get; set; }
	}
}
