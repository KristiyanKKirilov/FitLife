using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;

namespace FitLife.Data.Models
{
    [Comment("Products")]
    public class Product : IDeletableEntity
    {
        public Product()
        {
            Id = Guid.NewGuid().ToString();
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

        [Required]
        [Comment("Time of creation")]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Comment("Product's state")]
        public bool IsDeleted { get; set; }
    }
}
