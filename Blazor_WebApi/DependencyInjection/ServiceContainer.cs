using Blazor_Domain_Library.Entities.Security;
using Blazor_Infrastructure_Library.DatabaseContext;
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
            services.AddDbContext<DbContextApplication>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
        public static IServiceCollection AddIdentity(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddIdentity<UserEntity, RoleEntity>(config =>
            {

            }).AddEntityFrameworkStores<DbContextApplication>()
            .AddDefaultTokenProviders()
            .AddRoles<RoleEntity>()
            .AddErrorDescriber<CustomIdentityError>()
            .AddPasswordValidator<PasswordValidator>()
            ;
            builder.Services.Configure<IdentityOptions>(options =>
            {
                //  Identity Configuration Options For Customization
                // User
                options.User.RequireUniqueEmail = true;
                // SignIn
                options.SignIn.RequireConfirmedEmail = true;
                // Lockout
                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
            });
            builder.Services.ConfigureApplicationCookie(options =>
            {
                //  Cookie Setting
                //options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.LoginPath = "/Identity/Login";
                options.AccessDeniedPath = "/Identity/AccessDenied";
                options.SlidingExpiration = true;
            });
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
