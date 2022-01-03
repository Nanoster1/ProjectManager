using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectManager;
using ProjectManager.Models.Database;
using DbContext = ProjectManager.Models.Database.DbContext;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var settings = new Settings(builder.Configuration);

// Add services to the container.
var mvcBuilder = services.AddControllersWithViews();
services.AddDbContext<DbContext>(settings.SetDbOptions);
services.AddIdentityCore<User>(settings.SetIdentityOptions).AddEntityFrameworkStores<DbContext>();

if (builder.Environment.IsDevelopment())
{
    mvcBuilder.AddRazorRuntimeCompilation();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();