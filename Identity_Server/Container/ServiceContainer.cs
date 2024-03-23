using Identity_Server.DatabaseApplication;
using Identity_Server.Domain;
using Identity_Server.Repository;
using Identity_Server.Service;
using Microsoft.AspNetCore.Identity;

namespace Identity_Server.Container
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddSecurityServices(this IServiceCollection services)
        {
            services.AddScoped<IRoleClaimRepository, RoleClaimService>();
            services.AddScoped<IRoleRepository, RoleService>();
            services.AddScoped<IUserRepository, UserService>();
            services.AddScoped<IUserClaimRepository, UserClaimService>();
            services.AddScoped<IUserLoginRepository, UserLoginService>();
            services.AddScoped<IUserRepository, UserService>();
            services.AddScoped<IUserRoleRepository, UserRoleService>();
            services.AddScoped<IUserTokenRepository, UserTokenService>();
            return services;
        }

        public static IServiceCollection AddIdentity(this IServiceCollection services,
            IConfiguration configuration
            )
        {
            services.AddIdentity<UserEntity, RoleEntity>()
                .AddEntityFrameworkStores<DbContextApplication>();
            return services;
        }
    }
}
