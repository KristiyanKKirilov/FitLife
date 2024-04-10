using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitLife.Data.Configuration
{
    public class EventCategoryConfiguration : IEntityTypeConfiguration<EventCategory>
    {
        public void Configure(EntityTypeBuilder<EventCategory> builder)
        {
            throw new NotImplementedException();
        }
    }
}
