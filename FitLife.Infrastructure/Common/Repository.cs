using Microsoft.EntityFrameworkCore;

namespace FitLife.Data.Common
{
    public class Repository : IRepository
    {
        private readonly FitLifeDbContext context;

        public Repository(FitLifeDbContext _context)
        {
            context = _context;
        }
        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return DbSet<T>()                
                .AsNoTracking();
        }        

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        public void Remove<T>(T entity) where T : class
        {
            DbSet<T>().Remove(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        private DbSet<T> DbSet<T>() where T : class 
        {
            return context.Set<T>();
        }
    }
}
