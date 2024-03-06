using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Domain_Library.Entities.Security
{
    [Table("UserToken", Schema = "SEC"), Description("توکن کاربر")]
    public class UserTokenEntity : IdentityUserToken<long>
    {
    }
}
