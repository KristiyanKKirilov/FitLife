using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;

namespace FitLife.Data.Models
{
    [Comment("EventCategories")]
    public class EventCategory 
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
        public ICollection<Event> Events { get; set; }

    }
}
