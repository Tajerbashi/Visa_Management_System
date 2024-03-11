using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Client_Service_GEN.Models
{
    public class ResultModel<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
    }
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Family{ get; set; }
        [EmailAddress]
        public string Email{ get; set; }
        [PasswordPropertyText]
        public string Password{ get; set; }
    }
}
