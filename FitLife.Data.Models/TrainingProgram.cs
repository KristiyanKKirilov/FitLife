using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitLife.GlobalConstants.DataConstants.TrainingProgram;
using static FitLife.GlobalConstants.DataConstants;


namespace FitLife.Data.Models
{
    [Comment("TrainingPrograms")]
    public class TrainingProgram
    {
        public TrainingProgram()
        {
            Id = Guid.NewGuid().ToString();
            TrainingProgramsTrainers = new HashSet<TrainingProgramTrainer>();
            TrainingProgramsParticipants = new HashSet<TrainingProgramParticipant>();
        }

        [Key]
        [Comment("Training program's identifier")]
        public string Id { get; set; } = null!;

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("Training program's title")]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Training program's description")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("Training program's image url")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Comment("Training program's date of start in format dd/MM/yyyy hh:mm")]
        public DateTime StartDate { get; set; }

        [Required]
        [Range(DurationMinDays, DurationMaxDays)]
        [Comment("Training program's duration in days")]
        public int DurationDays { get; set; }

        [Required]
        [Comment("Training program's category identifier")]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public TrainingProgramCategory Category { get; set; } = null!;

        [Required]
        [Comment("Training program's creator")]
        public string CreatorId { get; set; } = null!;
        [ForeignKey(nameof(CreatorId))]
        public Trainer Creator { get; set; } = null!;        

        public ICollection<TrainingProgramTrainer> TrainingProgramsTrainers { get; set; }

        public ICollection<TrainingProgramParticipant> TrainingProgramsParticipants { get; set; }

    }
}
