using Microsoft.EntityFrameworkCore;
using Resturant.Domain.Entities;

namespace Resturant.Infrastructure.Context;

public class RestaurantContext:DbContext
{
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
}
