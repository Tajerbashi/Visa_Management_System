using System.ComponentModel.DataAnnotations;

namespace Blazor_Domain_Library.Entities.Test
{
    public class Person
    {
        public int ID { get; set; }
        public Guid Guid { get; set; }
        /// <summary>
        /// آقا یک خانم دو
        /// </summary>
        public byte Sex { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="نام را وارد کنید")]
        [StringLength(50,ErrorMessage ="تعداد حروف کمتر از 50 باشد")]
        public string Name { get; set; }
        public string Family { get; set; }
        public string Email { get; set; }
        [Range(18,35,ErrorMessage ="سن باید در محدوده باشد")]
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Re_Password { get; set; }
        public string Phone { get; set; }
    }

    public static class DatabaseContext
    {
        public static List<Person> GetAll()
        {
            return new List<Person>
            {

            };
        }

    }
}
