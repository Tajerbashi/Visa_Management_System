using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Domain_Library.Entities.Security
{
    [Table("User", Schema = "Security"), Description("کاربران")]
    public class UserEntity : IdentityUser<long>
    {
        [Description("نام")]
        public string Name { get; set; }

        [Description("فامیل")]
        public string Family { get; set; }


        [Description("حذف شده"), DefaultValue(false)]
        public bool IsDeleted { get; set; }

        [Description("فعال"), DefaultValue(false)]
        public bool IsActive { get; set; }
    }
}
