namespace Resturant.Api.Routers;

public static class RouteConfig
{
    public static void ConfigureRoutes(WebApplication app)
    {
        app.MapControllers();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Category}/{action=Index}/{id?}");

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Category}/{action=New}/{id?}");

        app.MapControllerRoute(
          name: "default",
          pattern: "{controller=Product}/{action=Index}/{id?}");

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Product}/{action=New}/{id?}");
    }
}
