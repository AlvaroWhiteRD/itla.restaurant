using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Resturant.Infrastructure.Data;
using System.Reflection;
namespace Resturant.Infrastructure.Extentions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
    {
        string database = "School.db";

        services.AddDbContext<RestaurantContext>(options =>
            options.UseSqlite(connectionString: "Filename=" + database,
                sqliteOptionsAction: op =>
                {
                    op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                })
        );

        return services;
    }
}

   /* public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        return services;
    }*/

//}

