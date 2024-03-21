using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity_Server.Domain
{
    [Table("UserLogin", Schema = "Security"), Description("لاگین های کاربر")]
    public class UserLoginEntity : IdentityUserLogin<long>
    {
        [Description("حذف شده"), DefaultValue(false)]
        public bool IsDeleted { get; set; }

        [Description("فعال"), DefaultValue(false)]
        public bool IsActive { get; set; }
    }
}
