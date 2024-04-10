using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitLife.Data.Models.Constants.DataConstants;

namespace FitLife.Data.Models
{
    [Comment("Trainers")]
    public class Trainer : IDeletableEntity
    {
        public Trainer()
        {
            Id = Guid.NewGuid().ToString();
            TrainingProgramsTrainers = new HashSet<TrainingProgramTrainer>();
            TrainersEvents = new HashSet<TrainerEvent>();
        }

        [Key]
        [Comment("Trainer's identifier")]
        public string Id { get; set; } 

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Trainer's first name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Trainer's last name")]
        public string LastName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Comment("Trainer's email address")]
        public string Email { get; set; } = null!;

        [Required]
        [Comment("Trainer's user identifier")]
        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public Participant User { get; set; } = null!;

        [Required]
        [Comment("Time of creation")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Trainer's state")]
        public bool IsDeleted { get; set; }

        public ICollection<TrainingProgramTrainer> TrainingProgramsTrainers { get; set; }

        public ICollection<TrainerEvent> TrainersEvents { get; set; }
        
    }
}
