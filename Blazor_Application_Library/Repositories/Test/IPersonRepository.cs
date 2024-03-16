using Blazor_Domain_Library.Entities.Test;

namespace Blazor_Application_Library.Repositories.Test
{
    public interface IPersonRepository
    {
        int Create(Person person);
        bool Update(Person person);
        bool Delete(Person person);
        bool Delete(int id);
        Person Read(int id);
        IList<Person> Read();

        bool SaveChanges();
    }
}
