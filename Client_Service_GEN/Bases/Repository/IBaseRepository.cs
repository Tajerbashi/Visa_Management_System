using Client_Service_GEN.Bases.Model;
using Client_Service_GEN.ContextDB;
using Client_Service_GEN.Models;

namespace Client_Service_GEN.Bases.Repository
{
    public interface IBaseRepository<T> where T : IBaseModel
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        T Get(long ID);
        IList<T> GetAll();
    }
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : UserModel
    {
        protected DataContextDB DataContextDB;
        protected BaseRepository()
        {
            DataContextDB = new DataContextDB();
        }
        public bool Add(T entity)
        {
            try
            {
                DataContextDB.UserModels.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public T Get(long ID)
        {
            try
            {
                var entity = DataContextDB.UserModels.Where(c => c.ID == ID).SingleOrDefault();
                return (T)entity;
            }
            catch
            {
                return null;
            }
        }

        public IList<T> GetAll()
        {
            try
            {
                var entity = DataContextDB.UserModels.ToList();
                return (IList<T>)entity.ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool Remove(T entity)
        {
            try
            {
                DataContextDB.UserModels.Remove(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                var model = DataContextDB.UserModels.Where(x => x.ID == entity.ID).Single();
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
