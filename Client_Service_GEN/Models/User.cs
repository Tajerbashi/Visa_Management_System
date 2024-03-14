using Client_Service_GEN.Bases.Model;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Client_Service_GEN.Models
{
    [Table("Users", Schema = "Security"), Description("")]
    public class User : IdentityUser<long>, IBaseEntity
    {
    }
    [Table("RoleClaim", Schema = "Security"), Description("اعتبارات نقش")]
    public class RoleClaim : IdentityRoleClaim<long>
    {
    }
    [Table("Role", Schema = "Security"), Description("نقش")]
    public class Role : IdentityRole<long>
    {

        public Role(string Role) : base(Role)
        {

        }

        public Role()
        {

        }
    }
    [Table("UserClaim", Schema = "Security"), Description("اعتبارات کاربر")]
    public class UserClaim : IdentityUserClaim<long>

    {
    }
    [Table("UserLogin", Schema = "Security"), Description("لاگین های کاربر")]
    public class UserLogin : IdentityUserLogin<long>
    {
    }
    /// <summary>
    /// نقش کاربر
    /// </summary>
    [Table("UserRole", Schema = "Security"), Description("نقش کاربر")]
    public class UserRole : IdentityUserRole<long>
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Description("شناسه")]
        public long ID { get; set; }


        [Description("پیش فرض")]
        public bool IsDefault { get; set; }

        [Description("فعال")]
        public bool IsActive { get; set; }

    }
    [Table("UserToken", Schema = "SEC"), Description("توکن کاربر")]
    public class UserToken : IdentityUserToken<long>
    {
    }
}
