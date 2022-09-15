using DataLayer.Interfaces;

namespace DataLayer.Repositories
{
    public abstract class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : class
    {
        readonly TodoContext _todoContext;

        public DataRepository(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _todoContext.Set<TEntity>().ToList();
        }

        public TEntity Get(long id)
        {
            return _todoContext.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            _todoContext.Set<TEntity>().Add(entity);
            _todoContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _todoContext.Set<TEntity>().Remove(entity);
            _todoContext.SaveChanges();
        }
    }
}
