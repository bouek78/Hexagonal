var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddLogging();




builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
//app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.UseSpa(spa =>
{
    if (app.Environment.IsDevelopment())
    {
        spa.Options.SourcePath = "ClientApp";
        // Launch development server for Vue.js
        spa.UseProxyToSpaDevelopmentServer("http://localhost:5173");
    }
});

app.Run();
