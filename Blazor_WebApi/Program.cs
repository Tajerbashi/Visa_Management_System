using Blazor_Application_Library.Models.Security;
using Blazor_Application_Library.Repositories.Security;
using Blazor_Domain_Library.Entities.Security;
using Blazor_Infrastructure_Library.DatabaseContext;
using Blazor_Infrastructure_Library.Services.Security;
using Blazor_WebApi.DependencyInjection;
using Blazor_WebApi.Helper.Validator;
using Blazor_WebApi.Middleware;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/Components");
builder.Services.AddAutoMapper(typeof(Program));
// Add Base Services For Project Blazor
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//  Add Database
builder.Services.AddDatabase(builder);
//  Add Identity Services
builder.Services.AddIdentity<UserEntity, RoleEntity>()
    .AddEntityFrameworkStores<DbContextApplication>()
    .AddDefaultTokenProviders()
    .AddSignInManager()
    //.AddRoles<RoleEntity>()
    //.AddRoleValidator<RoleEntity>()
    //.AddPasswordValidator<PasswordValidator>()
    //.AddEntityFrameworkStores<DbContextApplication>()
    ;
//  Add ServiceInjector
builder.Services.AddRepositories();

builder.Services.AddScoped<DbContextApplication>();
builder.Services.AddScoped<UserManager<UserEntity>>();
builder.Services.AddScoped<SignInManager<UserEntity>>();
builder.Services.AddScoped<IUserService, UserService>();
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
app.UseAuthentication();
app.MapBlazorHub();
app.MapFallbackToPage("/Views/_Host");
app.MapGet("/api/Security/Login", (
    IUserService service) =>
{
    return Results.Ok(service.Login(new LoginDTO
    {
        UserName = "Tajerbashi",
        Password = "@Tajer#1999",
        IsPersistence = true
    }));
});
app.UseWebApiProvider();
app.MapDefaultControllerRoute();
app.Run();
