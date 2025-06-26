using YRTJapan.DataAccess.Data;
using YRTJapan.DataAccess.Repository;
using YRTJapan.DataAccess.Repository.IRepository;
using YRTJapan.Core;
using YRTJapan.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using YRTJapan.Core.Entities;
using YRTJapan.UI.Services;
using YRTJapan.UI.Services.Interfaces;
using YRTJapan.UI.Helper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});
builder.Services.AddRazorPages();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddScoped<IApiService, ApiService>();
builder.Services.AddMemoryCache();
builder.Services.AddSingleton<ICacheService, CacheService>();
builder.Services.AddScoped<IDataService, DataService>();
builder.Services.AddScoped<CountryService>();
var emailConfig = builder.Configuration
                  .GetSection("SMTP")
                  .Get<SMTP>();
builder.Services.AddSingleton(emailConfig);
builder.Services.AddScoped<IEmailSender, EmailSender>();

builder.Services.AddHttpClient(); // for HttpClient usage
builder.Services.AddTransient<IImageService, ImageService>();

var app = builder.Build();

// Preload static data so it's initialized once at startup.
var preloadYearsList = DropdownHelper.GetYearsList;
var preloadPriceFromList = DropdownHelper.GetPriceFromList;
var preloadPriceToList = DropdownHelper.GetPriceToList;
var preloadFuelList = DropdownHelper.GetFuelList;
var preloadTransmissionList = DropdownHelper.GetTransmissionList;
var preloadGetGenderList = DropdownHelper.GetGenderList;
var preloadBodyTypesList = DropdownHelper.GetBodyTypesList;
var preloadSteeringList = DropdownHelper.Steering;
var preloadJapenesMakersList = DropdownHelper.GetJapenesMakersList;
var preloadGlobalMakerList = DropdownHelper.GetGlobalMakerList;
var preloadCountriesList = DropdownHelper.GetCountriesList;
var preloadDropdownBodyTypesList = DropdownHelper.GetDropdownBodyTypesList;

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
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

//app.MapControllerRoute(
//    name: "login",
//    pattern: "Login",
//    defaults: new { area = "Identity", controller = "Account", action = "Login" });

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
