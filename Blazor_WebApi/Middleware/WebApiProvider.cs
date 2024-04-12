using Blazor_Application_Library.Repositories.Security;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Blazor_WebApi.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class WebApiProvider
    {
        private readonly RequestDelegate _next;
        public WebApiProvider(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, IUserService userService)
        {
            var result = httpContext.Request.Path.Value.Split("/");
            string ServiceName = result[1];
            string MethodName = result[1];
            if (result.Length > 2)
            {
                ServiceName = result[1];
                MethodName = result[2];
            }
            userService.AddLog(new Blazor_Application_Library.Models.Security.HttpContextDTO
            {
                IsActive = true,
                IsDeleted = false,
                Time = DateTime.Now,
                ServiceName = ServiceName,
                MethodName = MethodName,
            });
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class WebApiProviderExtensions
    {
        public static IApplicationBuilder UseWebApiProvider(this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<WebApiProvider>();
        }
    }
}
