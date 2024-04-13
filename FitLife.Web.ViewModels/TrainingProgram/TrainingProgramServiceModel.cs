using System.ComponentModel.DataAnnotations;
using static FitLife.GlobalConstants.DataConstants;
using static FitLife.GlobalConstants.ErrorMessages;

namespace FitLife.Web.ViewModels.TrainingProgram
{
    public class TrainingProgramServiceModel
    {
        [Key]
        public string Id { get; set; } = null!;

        [Required(ErrorMessage = RequiredError)]
        [StringLength(TitleMaxLength,
             MinimumLength = TitleMinLength,
            ErrorMessage = StringLengthError)]
        public string Title { get; set; } = null!;       

        [Required(ErrorMessage = RequiredError)]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredError)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = RequiredError)]
        public int Duration { get; set; }

        [Required(ErrorMessage = RequiredError)]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }       

        [Required(ErrorMessage = RequiredError)]
        [Display(Name = "Trainer")]
        public string CreatorName { get; set; } = null!;    

    }
}
