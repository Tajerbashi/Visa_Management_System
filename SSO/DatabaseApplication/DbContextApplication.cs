using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSO.Domains;
using SSO.Models.DTOs;

namespace SSO.DatabaseApplication
{
    public class DbContextApplication
       : IdentityDbContext<UserEntity, RoleEntity, long, UserClaimEntity, UserRoleEntity, UserLoginEntity, RoleClaimEntity, UserTokenEntity>
    {
        public DbContextApplication(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<BlogEntity> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            #region SEC
            modelBuilder.Entity<BlogEntity>().ToTable("Blogs", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<UserEntity>().ToTable("Users", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<RoleEntity>().ToTable("Roles", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<RoleClaimEntity>().ToTable("RoleClaims", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<UserClaimEntity>().ToTable("UserClaims", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<UserLoginEntity>().ToTable("UserLogins", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive).HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId });
            modelBuilder.Entity<UserRoleEntity>().ToTable("UserRoles", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive).HasKey(x => new { x.ID, x.UserId, x.RoleId });
            modelBuilder.Entity<UserTokenEntity>().ToTable("UserTokens", "Security").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<UserEntity>().HasIndex(x => x.Email).IsUnique();


            //modelBuilder.Entity<UserRoleEntity>().Property(x => new { x.IsDefault,x.IsDeleted,x.IsActive}).ValueGeneratedOnAddOrUpdate();
            #endregion

            modelBuilder.ApplyConfiguration(new BlogConfiguration());
        }
    }
}
