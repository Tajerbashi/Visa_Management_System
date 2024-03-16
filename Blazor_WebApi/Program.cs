using Blazor_Application_Library.Repositories.Test;
using Blazor_Domain_Library.Entities.Security;
using Blazor_Domain_Library.Entities.Securityk;
using Blazor_Infrastructure_Library.DatabaseContext;
using Blazor_Infrastructure_Library.Services.Test;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
#region Assembly
//builder.Services.AddRazorComponents()
//    .AddInteractiveServerComponents()
//    .AddInteractiveWebAssemblyComponents();
#endregion
builder.Services.AddDbContext<DbContextApplication>(options =>
{
    //options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddDefaultIdentity<UserEntity>
    (options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DbContextApplication>();

#region ServiceContainer
builder.Services.AddScoped<IPersonRepository, PersonService>();
#endregion
#region Identity
builder.Services.AddIdentity<UserEntity, RoleEntity>()
    .AddEntityFrameworkStores<DbContextApplication>()
    .AddDefaultTokenProviders()
    ;

#endregion




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

#region Identity
app.UseAuthentication();
app.UseAuthorization();
#endregion

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
