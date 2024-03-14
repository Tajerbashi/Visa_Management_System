using MainServer.Components;
using MainServer.DatabaseApplication;
using MainServer.Repositories;
using MainServer.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IPersonRepository, PersonServices>();
//builder.Services.AddDbContext<DbContextApplication>(options =>
//{
//    //options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection"));
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
//});
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
