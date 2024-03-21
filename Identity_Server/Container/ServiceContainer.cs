using Identity_Server.Repository;
using Identity_Server.Service;

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
    }
}
