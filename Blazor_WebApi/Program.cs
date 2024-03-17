using Blazor_Application_Library.Repositories.Test;
using Blazor_Domain_Library.Entities.Security;
using Blazor_Domain_Library.Entities.Securityk;
using Blazor_Infrastructure_Library.DatabaseContext;
using Blazor_Infrastructure_Library.Services.Test;
using Blazor_WebApi.Provider;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);





#region ServiceContainer
builder.Services.AddScoped<IPersonRepository, PersonService>();
#endregion

#region DefaulService
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
// Add services to the container.
builder.Services.AddDbContext<DbContextApplication>(options =>
{
    //options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
#endregion

#region Identity
builder.Services.AddIdentity<UserEntity, RoleEntity>(options =>
{
    options.User.RequireUniqueEmail = false;
})
    .AddEntityFrameworkStores<DbContextApplication>()
    .AddDefaultTokenProviders()
    .AddDefaultUI()
    ;
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddTransient<IEmailSender, SMSSender>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

#region Identity
app.UseAuthentication();
app.UseAuthorization();

#endregion
app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
