using System.ComponentModel.DataAnnotations;

namespace FitLife.Web.ViewModels.Participant
{
	public class AllParticipantsQueryModel
	{
        public AllParticipantsQueryModel()
        {
            Participants = new HashSet<ParticipantServiceModel>();
        }

        [Display(Name = "Search by text")]
		public string SearchTerm { get; set; } = null!;

		public int TotalParticipantsCount { get; set; }
		public IEnumerable<ParticipantServiceModel> Participants { get; set; }
    }
}
