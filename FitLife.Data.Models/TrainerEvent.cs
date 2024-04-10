using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLife.Data.Models
{
    [Comment("TrainersEvents")]
    public class TrainerEvent : IDeletableEntity
    {
        [Required]
        [Comment("Trainer's identifier")]
        public string TrainerId { get; set; } = null!; 
        [ForeignKey(nameof(TrainerId))]
        public Trainer Trainer { get; set; } = null!;

        [Required]
        [Comment("Event's identifier")]
        public string EventId { get; set; } = null!;
        [ForeignKey(nameof(EventId))]
        public Event Event { get; set; } = null!;

        [Required]
        [Comment("Time of creation")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Order's state")]
        public bool IsDeleted { get; set; }
    }
}
