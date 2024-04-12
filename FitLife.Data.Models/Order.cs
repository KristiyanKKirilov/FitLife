using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLife.Data.Models
{
    [Comment("Orders")]
    public class Order
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

        public ICollection<Product> Products { get; set; }
        
    }
}
