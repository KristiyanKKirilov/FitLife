using FitLife.Data.Models;
using FitLife.Web.ViewModels.Event;
using FitLife.Web.ViewModels.TrainingProgram;

namespace System.Linq
{
	public static class IQueryableEventExtension
	{
		public static IQueryable<EventServiceModel> ProjectToEventServiceModel(this IQueryable<Event> events)
		{
			return events
				.Select(e => new EventServiceModel()
				{
					Id = e.Id,
					ImageUrl = e.ImageUrl,
					StartTime = e.StartTime,
					CategoryName = e.Category.Name,
					Title = e.Title,
					Address = e.Address,
					City = e.City,
					CreatorName = e.Creator.FirstName + " " + e.Creator.LastName
				});
		}
	}
}
