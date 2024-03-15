using MainServer.Bases.Models;
using MainServer.Bases.Repository;

namespace MainServer.Bases.Service
{
    public abstract class BaseService<T> : IBaseRepository<T>
         where T : BaseEntity<long>, new()
    {
        public abstract bool Add(T entity);

        public abstract bool AddOrUpdate(T entity);

        public abstract T Get(long ID);

        public abstract IList<T> GetAll();

        public abstract bool Remove(T entity);

        public abstract bool Remove(long id);
        
        public abstract bool Update(T entity);
    }
}
