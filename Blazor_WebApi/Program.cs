using Blazor_WebApi.DependencyInjection;
using Microsoft.AspNetCore.Mvc.RazorPages;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(Program));

#region DatabaseConfig
builder.Services.AddDatabase(builder);
builder.Services.AddIdentity();
builder.Services.AddClaims();
builder.Services.AddRequirements();
builder.Services.AddPolicies();
builder.Services.AddRepositories();
#endregion


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/Components");

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

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

app.MapBlazorHub();
app.MapFallbackToPage("/Views/_Host");

app.Run();
