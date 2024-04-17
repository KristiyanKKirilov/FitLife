using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLife.Data.Models
{
    public class ParticipantProduct
    {

        public ParticipantProduct()
        {
			Id = Guid.NewGuid().ToString();
		}
        [Key]
        public string Id { get; set; }

        [Required]
        [Comment("Participant's identifier")]
        public string ParticipantId { get; set; } = null!;
        [ForeignKey(nameof(ParticipantId))]
        public Participant Participant { get; set; } = null!;

        [Required]
        [Comment("Product's identifier")]
        public string ProductId { get; set; } = null!;
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

       
    }
}
