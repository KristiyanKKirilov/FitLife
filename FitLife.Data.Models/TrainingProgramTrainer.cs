using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLife.Data.Models
{
    [Comment("TrainingProgramsTrainers")]
    public class TrainingProgramTrainer : IDeletableEntity
    {
        [Required]
        [Comment("Trainer's identifier")]
        public string TrainerId { get; set; } = null!; 
        [ForeignKey(nameof(TrainerId))]
        public Trainer Trainer { get; set; } = null!;

        [Required]
        [Comment("Training program's identifier")]
        public string TrainingProgramId { get; set; } = null!;
        [ForeignKey(nameof(TrainingProgramId))]
        public TrainingProgram TrainingProgram { get; set; } = null!;

        [Required]
        [Comment("Time of creation")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("TrainingProgramsTrainers state")]
        public bool IsDeleted { get; set; }
    }
}
