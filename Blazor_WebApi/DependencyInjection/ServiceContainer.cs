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
            services.AddDbContext<DbContextApplication>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<UserEntity, RoleEntity>(config =>
            {

            }).AddEntityFrameworkStores<DbContextApplication>()
            .AddDefaultTokenProviders()
            .AddRoles<RoleEntity>()
            .AddErrorDescriber<CustomIdentityError>()
            .AddPasswordValidator<PasswordValidator>()
            ;
            services.Configure<IdentityOptions>(options =>
            {
                //  Identity Configuration Options For Customization
                // User
                //options.User.RequireUniqueEmail = true;
                // SignIn
                //options.SignIn.RequireConfirmedEmail = true;
                // Lockout
                //options.Lockout.AllowedForNewUsers = true;
                //options.Lockout.MaxFailedAccessAttempts = 3;
                //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
            });
            services.ConfigureApplicationCookie(options =>
            {
                //  Cookie Setting
                //options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.LoginPath = "/Security/Login";
                options.AccessDeniedPath = "/Security/AccessDenied";
                options.SlidingExpiration = true;
            });
            services.AddCascadingAuthenticationState();
            services.AddOptions();
            services.AddAuthentication();
            services.AddAuthorization();
            return services;
        }
        public static IServiceCollection AddClaims(this IServiceCollection services)
        {
            return services;
        }
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserService,UserService>();
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
