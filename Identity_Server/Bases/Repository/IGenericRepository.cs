using Identity_Server.Bases.Model;

namespace Identity_Server.Bases.Repository
{
    public interface IGenericRepository<T>
        where T : class
    {
        Result<long> Create(T entity);
        Result<bool> Update(T entity);
        Result<bool> Delete(T entity);
        Result<bool> Delete(long ID);
        Result<T> Read();
        Result<List<T>> ReadAll();
    }
}
