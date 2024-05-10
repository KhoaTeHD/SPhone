using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SPhone.Areas.Identity.Data;
using SPhone.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SPhoneContextConnection") ?? throw new InvalidOperationException("Connection string 'SPhoneContextConnection' not found.");

builder.Services.AddDbContext<SPhoneContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SPhoneUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SPhoneContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
