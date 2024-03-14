using Client_Service_GEN.Bases.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Client_Service_GEN.Models
{
    [Table("People", Schema = "Security"), Description("")]
    public class Person : BaseEntity<long>
    {
        public string Name { get; set; }
        public string Family { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Description(""), MaxLength(11), MinLength(11)]
        public string Phone { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }
        public string Picture { get; set; }

    }
}
