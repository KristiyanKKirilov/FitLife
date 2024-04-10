using FitLife.Data.Models.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static FitLife.Data.Models.Constants.DataConstants;

namespace FitLife.Data.Models
{
    [Comment("Participants")]
    public class Participant : IdentityUser, IDeletableEntity
    {
        public Participant()
        {           
            Orders = new HashSet<Order>();
            ParticipantsEvents = new HashSet<ParticipantEvent>();
            TrainingProgramsParticipants = new HashSet<TrainingProgramParticipant>();
            //Roles = new HashSet<IdentityUserRole<string>>();
            //Claims = new HashSet<IdentityUserClaim<string>>();
            //Logins = new HashSet<IdentityUserLogin<string>>();
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

        [Required]
        [Comment("Time of creation")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Participant's state")]
        public bool IsDeleted { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<ParticipantEvent> ParticipantsEvents { get; set; }

        public ICollection<TrainingProgramParticipant> TrainingProgramsParticipants { get; set; }
                    
        //public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }
        //public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        //public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
