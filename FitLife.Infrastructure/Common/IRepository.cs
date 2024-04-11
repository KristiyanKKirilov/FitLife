namespace FitLife.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class, IDeletableEntity;

        IQueryable<T> AllReadOnly<T>() where T : class, IDeletableEntity;

        IQueryable<T> AllWithDeleted<T>() where T : class;

        IQueryable<T> AllReadOnlyWithDeleted<T>() where T : class;

        Task AddAsync<T>(T entity) where T : class;

        Task<int> SaveChangesAsync();

        Task<T?> GetByIdAsync<T>(object id) where T : class;

        void Remove<T>(T entity) where T : class, IDeletableEntity;
    }
}
