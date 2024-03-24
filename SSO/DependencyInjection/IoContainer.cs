using SSO.Repositpries;
using SSO.Services;

namespace SSO.DependencyInjection
{
    public static class IoContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserService>();
            services.AddScoped<IRoleRepository, RoleService>();
            return services;
        }
    }
}
