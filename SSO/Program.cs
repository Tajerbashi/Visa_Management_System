using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SSO.DatabaseApplication;
using SSO.DependencyInjection;
using SSO.Domains;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(Program));
// Add services to the container.
builder.Services.AddRazorPages();
#region DatabaseConfig
builder.Services.AddDbContext<DbContextApplication>(options =>
{
    //options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
#endregion

#region Identity
builder.Services
    .AddIdentity<UserEntity, RoleEntity>(config =>
{

})
    .AddEntityFrameworkStores<DbContextApplication>()
    .AddDefaultTokenProviders();
#endregion

builder.Services.AddRepositories();



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

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.Run();
