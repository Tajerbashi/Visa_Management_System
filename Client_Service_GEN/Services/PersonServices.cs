using Client_Service_GEN.Bases.Repository;
using Client_Service_GEN.ContextDB;
using Client_Service_GEN.Models;
using Client_Service_GEN.Repositories;

namespace Client_Service_GEN.Services
{
    public class PersonServices : BaseRepository<Person>, IPersonRepository
    {
        public PersonServices(DbContextApplication DataContextDB) : base(DataContextDB)
        {
        }
    }
}
