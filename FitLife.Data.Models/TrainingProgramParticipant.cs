using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLife.Data.Models
{
    [Comment("TrainingProgramsParticipants")]
    public class TrainingProgramParticipant
    {        
        [Required]
        [Comment("Participant's identifier")]
        public string ParticipantId { get; set; } = null!;
        [ForeignKey(nameof(ParticipantId))]
        public Participant Participant { get; set; } = null!;

        [Required]
        [Comment("Training program's identifier")]
        public string TrainingProgramId { get; set; } = null!;
        [ForeignKey(nameof(TrainingProgramId))]
        public TrainingProgram TrainingProgram { get; set; } = null!;        
    }
}
