using Database.Server.Bases.Models;
using Database.Server.DbContextApplication;
using Database.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace Database.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private DatabaseContext _databaseContext;
        public PersonController(
            ILogger<PersonController> logger,
            DatabaseContext databaseContext
            )
        {
            _logger = logger;
            _databaseContext = databaseContext;
        }

        [HttpPost]
        public Person Create(Person person)
        {
            try
            {
                _databaseContext.People.Add(person);
                _databaseContext.SaveChanges();
                var result  = new Result<Person>()
                {
                    Data = person,
                    Message="اطلاعات با موفقیت ذخیره شده است",
                    Ressult=true
                };
                return result.Data;
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public List<Person> Get()
        {
            #region Loop
            //for (int i = 1; i <= 10000; i++)
            //{
            //    _databaseContext.People.Add(new Person
            //    {
            //        Name = $"Person Name - {i}",
            //        Family = $"Person Family - {i}",
            //        Email = $"PersonEmail{i}@mail.com",
            //        UserName = $"Person UserName - {i}",
            //        Password = $"@@{i}##",
            //        Phone = $"09011001000",
            //        Picture = $"A ({i}).jpg",
            //        CreateDate = DateTime.Now,
            //        UpdateDate = DateTime.Now,
            //        IsActive = true,
            //        IsDeleted = false,
            //    });
            //}
            //_databaseContext.SaveChanges();
            #endregion

            try
            {
                var result  = new Result<List<Person>>()
                {
                    Data = _databaseContext.People.Take(20).ToList(),
                    Message="اطلاعات با موفقیت واکشی شده است",
                    Ressult=true
                };
                return result.Data;
            }
            catch
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public Person GetByID(long id)
        {
            try
            {
                var result  = new Result<Person>()
                {
                    Data = _databaseContext.People.Where(x => x.ID == id).FirstOrDefault(),
                    Message="اطلاعات با موفقیت واکشی شده است",
                    Ressult=true
                };
                return result.Data;
            }
            catch
            {
                throw;
            }
        }

        [HttpPut]
        public Person Update(Person person)
        {
            try
            {
                _databaseContext.People.Update(person);
                _databaseContext.SaveChanges();
                var result  = new Result<Person>()
                {
                    Data = person,
                    Message="اطلاعات با موفقیت ویرایش شده است",
                    Ressult=true
                };
                return result.Data;
            }
            catch
            {
                throw;
            }
        }

        [HttpDelete]
        public Person Delete(long id)
        {
            try
            {
                var entity = _databaseContext.People.Where(x => x.ID == id).SingleOrDefault();
                entity.IsDeleted = true;
                entity.IsActive = false;
                _databaseContext.People.Update(entity);
                _databaseContext.SaveChanges();
                var result  = new Result<Person>()
                {
                    Data = entity,
                    Message="اطلاعات با موفقیت حذف شده است",
                    Ressult=true
                };
                return result.Data;
            }
            catch
            {
                throw;
            }
        }

    }
}
