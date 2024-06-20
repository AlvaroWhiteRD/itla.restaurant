using Resturant.Domain.Interfaces.Categorys;
using Resturant.Domain.Interfaces.Products;
using Resturant.Infrastructure.Repositories.Categorys;
using Resturant.Infrastructure.Repositories.Productos;

namespace Resturant.Api.Repositories;

public static class RepositoryRegistrations
{
    public static void RegisterRepositories(IServiceCollection services)
    {
        services.AddScoped<IProduct, ProductoRepository>();
        services.AddScoped<ICategory, CategoryRepository>();
    }
}