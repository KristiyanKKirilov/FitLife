using FitLife.Web.ViewModels.Participant;
using FitLife.Data.Models;

namespace System.Liq
{
	public static class IQueryableParticipantExtension
	{
		public static IQueryable<ParticipantServiceModel> ProjectToParticipantServiceModel(this IQueryable<Participant> participants)
		{
			return participants
				.Select(p => new ParticipantServiceModel()
				{
					Id = p.Id,
					FirstName = p.FirstName,
					LastName = p.LastName,
					Email = p.Email,
				});
		}
	}
}
