using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Data
{
    public class FitLifeDbContext : IdentityDbContext
    {
        public FitLifeDbContext(DbContextOptions<FitLifeDbContext> options)
            : base(options)
        {
        }
    }
}