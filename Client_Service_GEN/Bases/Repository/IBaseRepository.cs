using Client_Service_GEN.Bases.Model;
using Client_Service_GEN.ContextDB;

namespace Client_Service_GEN.Bases.Repository
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
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity<long>, new()
    {
        protected DbContextApplication DataContextDB;
        protected BaseRepository(DbContextApplication DataContextDB)
        {
            this.DataContextDB = DataContextDB;
        }
        public virtual bool Add(T entity)
        {
            try
            {
                DataContextDB.Set<T>().Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddOrUpdate(T entity)
        {
            if (entity.ID == 0)
            {
                return Add(entity);
            }
            else
            {
                return Update(entity);
            }
        }

        public virtual T Get(long ID)
        {
            try
            {
                var entity = DataContextDB.Set<T>().Where(c => c.ID == ID).Single();
                return (T)entity;
            }
            catch
            {
                return null;
            }
        }

        public virtual IList<T> GetAll()
        {
            try
            {
                var entity = DataContextDB.Set<T>().ToList();
                return (IList<T>)entity.ToList();
            }
            catch
            {
                return null;
            }
        }

        public virtual bool Remove(T entity)
        {
            try
            {
                DataContextDB.Set<T>().Remove(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual bool Remove(long id)
        {
            try
            {
                var model = DataContextDB.Set<T>().Where(x => x.ID == id).Single();
                return Remove((T)model); ;
            }
            catch
            {
                return false;
            }
        }

        public virtual bool Update(T entity)
        {
            try
            {
                var model = DataContextDB.Set<T>().Where(x => x.ID == entity.ID).Single();
                model = entity;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
