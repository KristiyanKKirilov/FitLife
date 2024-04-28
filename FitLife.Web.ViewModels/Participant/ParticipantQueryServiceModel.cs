using FitLife.Web.ViewModels.Trainer;

namespace FitLife.Web.ViewModels.Participant
{
    public class ParticipantQueryServiceModel
	{
		public ParticipantQueryServiceModel()
		{
			Participants = new HashSet<ParticipantServiceModel>();
		}
		public int TotalParticipantsCount { get; set; }

		public IEnumerable<ParticipantServiceModel> Participants { get; set; }
	}
}
