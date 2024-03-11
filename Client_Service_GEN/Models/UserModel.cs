using Client_Service_GEN.Bases.Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Client_Service_GEN.Models
{
    public class UserModel : BaseModel
    {
        public string Name { get; set; }
        public string Family { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [PasswordPropertyText]
        public string Password { get; set; }
        public string Picture { get; set; }
    }
}
