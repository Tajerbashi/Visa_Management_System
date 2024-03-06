using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Domain_Library.Entities.Security
{
    [Table("RoleClaim", Schema = "Security"), Description("اعتبارات نقش")]
    public class RoleClaimEntity : IdentityRoleClaim<long>
    {
    }
}
