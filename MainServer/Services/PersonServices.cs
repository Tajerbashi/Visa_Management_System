using MainServer.Bases.Service;
using MainServer.Models;
using MainServer.Repositories;

namespace MainServer.Services
{
    public class PersonServices : BaseService<Person>, IPersonRepository
    {

        public PersonServices()
        {
            
        }
        public override bool Add(Person entity)
        {
            throw new NotImplementedException();
        }

        public override bool AddOrUpdate(Person entity)
        {
            throw new NotImplementedException();
        }

        public override Person Get(long ID)
        {
            throw new NotImplementedException();
        }

        public override IList<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Person entity)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(long id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
