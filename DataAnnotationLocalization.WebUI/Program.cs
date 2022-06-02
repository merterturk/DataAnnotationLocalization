using DataAnnotationLocalization.Resources;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddViewLocalization().AddDataAnnotationsLocalization();

builder.Services.AddLocalization(option =>
{
    option.ResourcesPath = "Resources";
});
builder.Services.Configure<RequestLocalizationOptions>(option =>
{
    option.DefaultRequestCulture = new RequestCulture("tr-TR");
    CultureInfo[] cultures = new CultureInfo[]
   {
        new("en-US"),
        new("tr-TR"),
        new("fr-FR")
   };
    option.SupportedUICultures = cultures;
    option.SupportedCultures = cultures;
    option.RequestCultureProviders = new List<IRequestCultureProvider>()
    {
        new CookieRequestCultureProvider()
    };
});

var app = builder.Build();
DataAnnotationResource.DataAnnotationResourceConfigure(app.Services.GetService<IStringLocalizer<DataAnnotationResource>>());
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
app.UseRequestLocalization();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
