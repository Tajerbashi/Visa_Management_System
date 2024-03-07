using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Blazor_WebApi.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RestoreDataHandler
    {
        private readonly RequestDelegate _next;

        public RestoreDataHandler(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RestoreDataHandlerExtensions
    {
        public static IApplicationBuilder UseRestoreDataHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RestoreDataHandler>();
        }
    }
}
