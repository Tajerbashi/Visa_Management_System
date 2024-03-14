using MainServer.Bases.Service;
using MainServer.DatabaseApplication;
using MainServer.Models;
using MainServer.Repositories;

namespace MainServer.Services
{
    public class PersonServices : BaseService<Person>, IPersonRepository
    {
        public PersonServices(DbContextApplication DataContextDB) : base(DataContextDB)
        {
        }
    }
}
