using Blazor_Application_Library.Repositories.Security;
using Blazor_Domain_Library.Entities.Security;
using Blazor_Infrastructure_Library.DatabaseContext;
using Blazor_Infrastructure_Library.Services.Security;
using Blazor_WebApi.Helper.Identity;
using Blazor_WebApi.Helper.Validator;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Blazor_WebApi.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddScoped<DbContextApplication>();
            services.AddDbContext<DbContextApplication>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<UserEntity,RoleEntity>()
                    .AddRoles<RoleEntity>()
                    .AddEntityFrameworkStores<DbContextApplication>()
                    .AddSignInManager()
                    .AddDefaultTokenProviders();
            return services;
        }
        public static IServiceCollection AddClaims(this IServiceCollection services)
        {
            return services;
        }
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            
            return services;
        }
        public static IServiceCollection AddRequirements(this IServiceCollection services)
        {
            return services;
        }
        public static IServiceCollection AddPolicies(this IServiceCollection services)
        {
            return services;
        }
    }
}
