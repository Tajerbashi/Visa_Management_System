using Blazor_Application_Library.Repositories.Test;
using Blazor_Domain_Library.Entities.Test;
using Blazor_Infrastructure_Library.DatabaseContext;

namespace Blazor_Infrastructure_Library.Services.Test
{
    public class PersonService : IPersonRepository
    {
        private DbContextApplication Context;
        public PersonService(DbContextApplication context)
        {
            Context = context;
        }
        public int Create(Person person)
        {
            try
            {
                Context.People.Add(person);
                SaveChanges();
                return person.ID;
            }
            catch
            {
                return 0;
            }
        }

        public bool Delete(Person person)
        {
            try
            {
                Context.People.Remove(person);
                SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = Read(id);
                Delete(entity);
                SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Person Read(int id)
        {
            try
            {
                var entity = Context.People.Find(id);
                return entity;
            }
            catch
            {
                return null;
            }
        }

        public IList<Person> Read()
        {
            try
            {
                var result = Context.People.ToList();
                return result;
            }
            catch
            {
                return null;
            }
        }

        public bool SaveChanges()
        {
            Context.SaveChanges();
            return true;
        }

        public bool Update(Person person)
        {
            try
            {
                Context.People.Update(person);
                SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
