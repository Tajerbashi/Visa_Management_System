using Blazor_Domain_Library.Entities.Security;
using Blazor_Domain_Library.Entities.Securityk;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Infrastructure_Library.DatabaseContext;

//public class DbContextApplication : IdentityDbContext<UserEntity, RoleEntity, long, UserClaimEntity, UserRoleEntity, UserLoginEntity, RoleClaimEntity, UserTokenEntity>
//{
//    public DbContextApplication(DbContextOptions<DbContextApplication> options)
//        : base(options)
//    {
//    }

//    protected override void OnModelCreating(ModelBuilder builder)
//    {
//        base.OnModelCreating(builder);
//        // Customize the ASP.NET Identity model and override the defaults if needed.
//        // For example, you can rename the ASP.NET Identity table names and more.
//        // Add your customizations after calling base.OnModelCreating(builder);
//    }
//}
