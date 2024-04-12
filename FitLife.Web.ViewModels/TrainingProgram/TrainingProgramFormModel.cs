using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.ErrorMessages;
using static FitLife.GlobalConstants.DataConstants;
using static FitLife.GlobalConstants.DataConstants.TrainingProgram;
using FitLife.Data.Models;

namespace FitLife.Web.ViewModels.TrainingProgram
{
    public class TrainingProgramFormModel
    {
        public TrainingProgramFormModel()
        {
            TrainingProgramCategories = new HashSet<TrainingProgramCategoryServiceModel>();
        }

        /// <summary>
        /// Training program's title
        /// </summary>
        [Required(ErrorMessage = RequiredError)]
        [StringLength(TitleMaxLength,
            MinimumLength = TitleMinLength,
            ErrorMessage = StringLengthError)]        
        public string Title { get; set; } = null!;

        /// <summary>
        /// Training program's description
        /// </summary>
        [Required(ErrorMessage = RequiredError)]
        [StringLength(DescriptionMaxLength, 
            MinimumLength = DescriptionMinLength, 
            ErrorMessage = StringLengthError)]       
        public string Description { get; set; } = null!;

        /// <summary>
        /// Training program's image url
        /// </summary>
        [Required(ErrorMessage = RequiredError)]        
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// Training program's date of start in format dd/MM/yyyy hh:mm
        /// </summary>
        [Required(ErrorMessage = RequiredError)]
        [Display(Name = "Start date")]
        public string StartDate { get; set; }

        /// <summary>
        /// Training program's duration in days
        /// </summary>
        [Required(ErrorMessage = RequiredError)]
        [Range(DurationMinDays, DurationMaxDays, ErrorMessage = DurationError)]
        [Display(Name = "Duration days")]
        public int DurationDays { get; set; }

        /// <summary>
        /// "Training program's category identifier"
        /// </summary>
        [Required(ErrorMessage = RequiredError)]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        
        public IEnumerable<TrainingProgramCategoryServiceModel> TrainingProgramCategories { get; set; }
    }
}
