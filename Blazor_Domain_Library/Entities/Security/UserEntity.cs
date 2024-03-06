using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Domain_Library.Entities.Security
{
    [Table("User", Schema = "Security"), Description("کاربران")]
    public class UserEntity : IdentityUser<long>
    {
    }
}
