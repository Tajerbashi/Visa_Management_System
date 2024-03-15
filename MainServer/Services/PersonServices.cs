using MainServer.Bases.Service;
using MainServer.Models;
using MainServer.Repositories;
using MainServer.WebService;

namespace MainServer.Services
{
    public class PersonServices : BaseService<Person>, IPersonRepository
    {
        private string baseUrl = "https://localhost:44325";

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
            var get = new GetService<List<Person>>(baseUrl,"/Person");
            var Result = get.Call();
            return Result.Result.Data.ToList();
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
