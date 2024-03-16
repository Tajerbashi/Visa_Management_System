using Blazor_Domain_Library.Entities.Security;
using Blazor_Domain_Library.Entities.Securityk;
using Blazor_Domain_Library.Entities.Test;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Blazor_Infrastructure_Library.DatabaseContext
{
    public class DbContextApplication : IdentityDbContext<UserEntity, RoleEntity, long, UserClaimEntity, UserRoleEntity, UserLoginEntity, RoleClaimEntity, UserTokenEntity>
    {
        public DbContextApplication(DbContextOptions<DbContextApplication> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            #region SEC
            modelBuilder.Entity<UserEntity>().ToTable("Users", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<RoleEntity>().ToTable("Roles", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<RoleClaimEntity>().ToTable("RoleClaims", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<UserClaimEntity>().ToTable("UserClaims", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<UserLoginEntity>().ToTable("UserLogins", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive).HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId });
            modelBuilder.Entity<UserRoleEntity>().ToTable("UserRoles", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive).HasKey(x => new { x.ID, x.UserId, x.RoleId });
            modelBuilder.Entity<UserTokenEntity>().ToTable("UserTokens", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<UserEntity>().HasIndex(x => x.Email).IsUnique();
            #endregion

        }

        public DbSet<Person> People { get; set; }

    }
}
