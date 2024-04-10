using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLife.Data.Models
{
    [Comment("Orders")]
    public class Order : IDeletableEntity
    {
        public Order()
        {
            Id = Guid.NewGuid().ToString();
            Products = new HashSet<Product>();
        }

        [Key]
        [Comment("Order identifier")]
        public string Id { get; set; }

        [Required]
        [Comment("Order's participant identifier")]
        public string ParticipantId { get; set; } = null!;
        [ForeignKey(nameof(ParticipantId))]
        public Participant Participant { get; set; } = null!;

        [Required]
        [Comment("Order's total price")]
        public decimal TotalPrice { get; set; }

        [Required]
        [Comment("Time of creation")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Order's state")]
        public bool IsDeleted { get; set; }

        public ICollection<Product> Products { get; set; }
        
    }
}
