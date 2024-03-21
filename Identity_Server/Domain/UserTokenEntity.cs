using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity_Server.Domain
{
    [Table("UserToken", Schema = "SEC"), Description("توکن کاربر")]
    public class UserTokenEntity : IdentityUserToken<long>
    {
        [Description("حذف شده"), DefaultValue(false)]
        public bool IsDeleted { get; set; }

        [Description("فعال"), DefaultValue(false)]
        public bool IsActive { get; set; }
    }
}
