using FitLife.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;

namespace FitLife.Data.Models
{
    [Comment("TrainingProgramCategories")]
    public class TrainingProgramCategory
    {
        public TrainingProgramCategory()
        {
            TrainingPrograms = new HashSet<TrainingProgram>();
        }

        [Key]
        [Comment("TrainingProgram category's identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("TrainingProgram category's name")]
        public string Name { get; set; } = null!;     

        public ICollection<TrainingProgram> TrainingPrograms { get; set; }
        
    }
}
