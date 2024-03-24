using AutoMapper;
using SSO.BaseSSO.Model;
using SSO.DatabaseApplication;

namespace SSO.BaseSSO.Repository
{
    public interface IGenericRepository<T> : IDisposable
        where T : BaseDTO, new()
    {
        Result<long> Create(T entity);
        Result<bool> Update(T entity);
        Result<bool> Delete(T entity);
        Result<bool> Delete(long ID);
        Result<T> Read(long Id);
        Result<List<T>> ReadAll();

        void BeginTransaction();
        void CommitTransaction();
        void RollBackTransaction();
        void SaveChanges();

    }
    public abstract class BaseServices<T>
        : IGenericRepository<T>
        where T : BaseDTO, new()
    {
        protected readonly DbContextApplication Context;
        protected readonly IMapper Mapper;
        protected BaseServices(
            DbContextApplication context,
            IMapper mapper
            )
        {
            Context = context;
            Mapper = mapper;
        }

        public void BeginTransaction()
        {
            Context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            Context.Database.CommitTransaction();
        }

        public abstract Result<long> Create(T entity);

        public abstract Result<bool> Delete(T entity);

        public abstract Result<bool> Delete(long ID);

        public void Dispose()
        {
            Context.Dispose();
        }

        public abstract Result<T> Read(long Id);
        

        public abstract Result<List<T>> ReadAll();

        public void RollBackTransaction()
        {
            Context.Database.RollbackTransaction();
        }

        public void SaveChanges() => Context.SaveChanges();

        public abstract Result<bool> Update(T entity);
    }
}
