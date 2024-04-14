using FitLife.Data.Models.Enumerations;
using FitLife.Web.ViewModels.Event;

namespace FitLife.Core.Contracts
{
	public interface IEventService
	{
		Task<EventQueryServiceModel> AllAsync(
			string? userCity,
			string? category = null, 
			string? searchTerm = null,
			EventSorting sorting = EventSorting.MostRecent,
			int currentPage = 1, 
			int eventsPerPage = 1);
		Task<IEnumerable<EventCategoryServiceModel>> AllCategoriesAsync();
		Task<IEnumerable<string>> AllCategoriesNamesAsync();
		Task<EventModifyModel?> GetEventModifyModelByIdAsync(string eventId);
		Task<IEnumerable<EventServiceModel>> AllEventsByTrainerAsync(string trainerId);
		Task<IEnumerable<EventServiceModel>> AllEventsByParticipantAsync(string participantId);
		Task<EventDetailsServiceModel> EventDetailsByIdAsync(string eventId);
		Task<bool> HasParticipantWithIdAsync(string eventId, string participantId);
		Task<string> CreateAsync(EventFormModel model, string trainerId);
		Task DeleteAsync(string eventId);
		Task<bool> CategoryExistsAsync(int categoryId);
		Task ModifyAsync(string eventId, EventModifyModel model);
		Task<bool> ExistsAsync(string eventId);
		Task JoinAsync(string eventId, string userId);
		Task<bool> HasTrainerWithIdAsync(string eventId, string userId);
	}
}
