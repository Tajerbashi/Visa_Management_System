using Domain_Driven_Design_Solution.Library_Domain.Base;
using Domain_Driven_Design_Solution.Library_Domain.Interfaces;
using Domain_Driven_Design_Solution.Library_Infrastructure.Data.Repositories;

namespace Domain_Driven_Design_Solution.Library_Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFContext _dbContext;

        public UnitOfWork(EFContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IAsyncRepository<T> AsyncRepository<T>() where T : BaseEntity
        {
            return new RepositoryBase<T>(_dbContext);
        }

        public IAsyncRepository<T> Repository<T>() where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
