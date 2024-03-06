using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Domain_Library.Entities.Security
{
    [Table("UserLogin", Schema = "Security"), Description("لاگین های کاربر")]
    public class UserLoginEntity : IdentityUserLogin<long>
    {
    }
}
