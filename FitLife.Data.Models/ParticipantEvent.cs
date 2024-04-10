using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FitLife.Data.Models
{
    [Comment("ParticipantsEvents")]
    public class ParticipantEvent : IDeletableEntity
    {
        [Required]
        [Comment("Participant's identifier")]
        public string ParticipantId { get; set; } = null!;
        [ForeignKey(nameof(ParticipantId))]
        public Participant Participant { get; set; } = null!;

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
