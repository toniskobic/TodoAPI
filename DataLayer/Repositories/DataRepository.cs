namespace DataLayer.Repositories
{
    using DataLayer.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public abstract class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : class
    {
        readonly TodoContext _todoContext;

        public DataRepository(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _todoContext.Set<TEntity>();
        }

        public IQueryable<TEntity> AsReadOnly()
        {
            return _todoContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetAsync(long id)
        {
            return await _todoContext.Set<TEntity>().FindAsync(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _todoContext.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _todoContext.Set<TEntity>().Remove(entity);
        }
    }
}
