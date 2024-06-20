using Microsoft.EntityFrameworkCore;
using Resturant.Domain.Services.Productos;

using Resturant.Infrastructure.Context;
using Resturant.Api.Routers;
using Resturant.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Services.AddServerSideBlazor();

//builder.Services.AddDbContext<RestaurantContext>(options => options.UseSqlite(connectionString: "Filename=Restaurant.db"));

builder.Services.AddDbContext<RestaurantContext>(options =>
{
    options.UseInMemoryDatabase("RestaurantDB");
});

RepositoryRegistrations.RegisterRepositories(builder.Services);
builder.Services.AddScoped<ProductServices>();

builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

RouteConfig.ConfigureRoutes(app);

app.Run();
