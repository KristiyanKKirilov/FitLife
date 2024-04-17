using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;
using static FitLife.GlobalConstants.DataConstants.Product;

namespace FitLife.Data.Models
{
    [Comment("Products")]
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid().ToString();
            ParticipantsProducts = new List<ParticipantProduct>();
        }

        [Key]
        [Comment("Product's identifier")]
        public string Id { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Product's name")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Product's nutrition described")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("Product's image url")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(MinPrice, MaxPrice)]
        [Comment("Product's price")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Product's state")]
        public bool IsAvailable { get; set; }

        [Required]
        [Comment("Product's available count in storage")]
        public int AvailableStockCount { get; set; }

        [Required]
        [Comment("Product's count in a participant's order")]
        public int Count { get; set; }       

        public IList<ParticipantProduct> ParticipantsProducts { get; set; }
    }
}
