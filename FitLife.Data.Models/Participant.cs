using FitLife.Data.Models.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;

namespace FitLife.Data.Models
{
    [Comment("Participants")]
    public class Participant : IdentityUser
    {
        public Participant()
        {
            ParticipantsProducts = new List<ParticipantProduct>();
            ParticipantsEvents = new HashSet<ParticipantEvent>();
            TrainingProgramsParticipants = new HashSet<TrainingProgramParticipant>();            
        }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Participant's first name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Participant's last name")]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(CityMaxLength)]
        [Comment("Participant's living town")]
        public string City { get; set; } = null!;       

        public IList<ParticipantProduct> ParticipantsProducts { get; set; }

        public ICollection<ParticipantEvent> ParticipantsEvents { get; set; }

        public ICollection<TrainingProgramParticipant> TrainingProgramsParticipants { get; set; }                    
      
    }
}
