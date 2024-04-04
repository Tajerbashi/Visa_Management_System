using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Domains
{
    /// <summary>
    /// نقش کاربر
    /// </summary>
    [Table("UserRole", Schema = "Security"), Description("نقش کاربر")]
    public class UserRoleEntity : IdentityUserRole<long>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Description("شناسه")]
        public long ID { get; set; }

        [Description("پیش فرض")]
        public bool IsDefault { get; set; }

        [Description("فعال"), DefaultValue(true)]
        public bool IsActive { get; set; } = true;

        [Description("حذف شده"), DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;

    }
}
