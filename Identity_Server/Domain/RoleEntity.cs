using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity_Server.Domain
{
    [Table("Role", Schema = "Security"), Description("نقش")]
    public class RoleEntity : IdentityRole<long>
    {

        public RoleEntity(string Role) : base(Role)
        {

        }

        public RoleEntity()
        {

        }
        [Description("حذف شده"), DefaultValue(false)]
        public bool IsDeleted { get; set; }

        [Description("فعال"), DefaultValue(false)]
        public bool IsActive { get; set; }
    }
}
