using Microsoft.AspNetCore.Authorization;
using SSO.Authorization.Requirements.Credit;
using SSO.Authorization.Requirements.SelfAccessUser;
using SSO.Domains;
using SSO.Helper;
using SSO.Models;
using SSO.Models.DTOs;
using SSO.Repositpries;
using SSO.Services;

namespace SSO.DependencyInjection
{
    public static class IoContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserService>();
            services.AddScoped<IBlogRepository, BlogService>();
            services.AddScoped<IRoleRepository, RoleService>();
            services.AddScoped<IMailRepository, MailService>();
            return services;
        }

        public static IServiceCollection AddRequirements(this IServiceCollection services)
        {
            services.AddSingleton<IAuthorizationHandler, CreditRequirementHandler>();
            services.AddSingleton<IAuthorizationHandler, SelfAccessUserToBlogRequirementHandler>();
            services.AddSingleton<IAuthorizationHandler, SelfAccessUserRequirementHandler<UserData>>();
            return services;
        }

        public static IServiceCollection AddPolicies(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Internal", policy => // Policy Name
                {
                    policy.RequireClaim("Internal"); // Claim Type
                });
                options.AddPolicy("Country", policy => // Policy Name
                {
                    policy.RequireClaim("Country", "Iran", "Afghanistan"); //    External is Claim Type : Iran & Afghanistan is Claim Values
                });
                options.AddPolicy("Credit", policy =>
                {
                    policy.Requirements.Add(new CreditRequirement(1000));
                });

                options.AddPolicy("SelfAccessUser", policy =>
                {
                    policy.Requirements.Add(new SelfAccessUserToBLogRequirement());
                });

                options.AddPolicy("AccessAdmin", policy =>
                {
                    policy.Requirements.Add(new SelfAccessUserRequirement<UserData>());
                });
            });
            return services;
        }
    }
}
