namespace Blazor_Application_Library.BaseApplication
{
    public interface IGenericRepository<TEntity, TDTO, TView>
    {
        void Create(TEntity entity);
        List<TEntity> Read();
        TEntity Read(object ID);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(object ID);
        bool Exist(long id);
    }
}
