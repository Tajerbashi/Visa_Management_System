using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SSO.Authorization.ExternalClaims;
using SSO.Authorization.IdentityErrors;
using SSO.Authorization.Validators;
using SSO.DatabaseApplication;
using SSO.DependencyInjection;
using SSO.Domains;
using SSO.Repositpries;

var builder = WebApplication.CreateBuilder(args);
#region AutoMapper
builder.Services.AddAutoMapper(typeof(Program));
#endregion
// Add services to the container.
builder.Services.AddControllersWithViews();
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
    //config.User.AllowedUserNameCharacters = "";
})
    .AddEntityFrameworkStores<DbContextApplication>()
    .AddDefaultTokenProviders()
    .AddRoles<RoleEntity>()
    .AddErrorDescriber<CustomIdentityError>()
    .AddPasswordValidator<PasswordValidator>()
    ;

builder.Services.AddPolicies();

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
#endregion

#region ClaimConfig
//  ایجاد کلیم های شخصی سازی شده برای اجرای کاربر و اضافه به کلیم های سیستم

//  این سرویس کامنت میشود برای اینکه کانفیگ های نقش های کاربر را جهت مدیریت دسترسی اضاقه کنیم
//builder.Services.AddScoped<IUserClaimsPrincipalFactory<UserEntity>, UserApplicationClaims>();

//  بجای سرویس بالا ازین روش استفاده میکنیم جهت وارد کردن کلیم های کاربر از هر مکانی که میتواند باشد
builder.Services.AddScoped<IClaimsTransformation, AddClaimsExternal>();
#endregion

builder.Services.AddRequirements();

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

app.MapGet("/sso/Users/ReadAll", (IUserRepository service) =>
{
    return Results.Ok(service.ReadAll());
});

app.MapDefaultControllerRoute();

app.Run();


