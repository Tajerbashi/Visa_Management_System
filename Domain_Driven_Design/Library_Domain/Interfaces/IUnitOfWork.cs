using Domain_Driven_Design_Solution.Library_Domain.Base;

namespace Domain_Driven_Design_Solution.Library_Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        IAsyncRepository<T> Repository<T>() where T : BaseEntity;
    }
}
