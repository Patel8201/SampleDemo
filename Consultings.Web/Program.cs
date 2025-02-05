using RepositoryLayer.Extensions;
using ServiceLayer.Extensions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.LoadRepositoryLayerExtensions(builder.Configuration);
builder.Services.LoadServiceLayerExtensions(builder.Configuration);

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
app.UseAuthentication();
app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

#pragma warning disable ASP0014
app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
        );
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        );
    endpoints.MapAreaControllerRoute(
         name: "User",
         areaName: "User",
         pattern: "User/{controller=Dashboard}/{action=Index}/{id?}"
         );
}
);
app.Run();
