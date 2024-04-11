using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;

namespace FitLife.Data.Models
{
    [Comment("EventCategories")]
    public class EventCategory : IDeletableEntity
    {
        public EventCategory()
        {
            Events = new HashSet<Event>();
        }

        [Key]
        [Comment("Event category's identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Event category's name")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Time of creation")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Event category's state")]
        public bool IsDeleted { get; set; }

        public ICollection<Event> Events { get; set; }
        
    }
}
