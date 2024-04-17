namespace FitLife.Data.Models.Common
{
    public interface IDeletableEntity
    {
        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; } 
    }
}
