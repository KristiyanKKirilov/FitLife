using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitLife.GlobalConstants.DataConstants;
using static FitLife.GlobalConstants.DataConstants.Event;

namespace FitLife.Data.Models
{
    [Comment("Events")]
    public class Event : IDeletableEntity
    {
        public Event()
        {
            Id = Guid.NewGuid().ToString();
            ParticipantsEvents = new HashSet<ParticipantEvent>();
        }

        [Key]
        [Comment("Event's identifier")]
        public string Id { get; set; } = null!;

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("Event's title")]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Event's description")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("Event's image url")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [MaxLength(CityMaxLength)]
        [Comment("Event's city")]
        public string City { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLength)]
        [Comment("Event's address in detail described")]
        public string Address { get; set; } = null!;

        [Required]
        [Comment("Event's start time in format dd/MM/yyyy hh:mm")]
        public DateTime StartTime { get; set; }

        [Required]
        [Comment("Event's category identifier")]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public EventCategory Category { get; set; } = null!;

        [Required]
        [Comment("Event's creator identifier")]
        public string CreatorId { get; set; } = null!;
        [ForeignKey(nameof(CreatorId))]
        public Trainer Creator { get; set; } = null!;

        [Required]
        [Comment("Time of creation")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Event's state")]
        public bool IsDeleted { get; set; }       

        public ICollection<ParticipantEvent> ParticipantsEvents { get; set; }

        
    }
}
