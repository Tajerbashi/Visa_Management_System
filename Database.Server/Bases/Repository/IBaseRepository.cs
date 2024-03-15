using Database.Server.Bases.Models;

namespace Database.Server.Bases.Repository
{
    public interface IBaseRepository<T> where T : IBaseEntity, new()
    {
        bool AddOrUpdate(T entity);
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        bool Remove(long id);
        T Get(long ID);
        IList<T> GetAll();
    }
}
