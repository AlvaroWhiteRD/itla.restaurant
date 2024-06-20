namespace Resturant.Infrastructure.Data;

using Microsoft.EntityFrameworkCore;
using Resturant.Domain.Entities;

public class RestaurantContext2 : DbContext
{
    public DbSet<Producto> Productos { get; set; }

    public RestaurantContext2()
    {
    }

    public RestaurantContext2(DbContextOptions contextOptions) : base(contextOptions)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>().ToTable("Productos");
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(p => p.Id);
        });

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      /*  string database = "Restaurant.db";
       // optionsBuilder.UseSqlite(connectionString: "Filename=" + database)
        optionsBuilder.UseSqlite(connectionString: "Filename=" + database,
            sqliteOptionsAction: op =>
            {
                op.MigrationsAssembly(
                    Assembly.GetExecutingAssembly().FullName
                    );
            });*/
        base.OnConfiguring(optionsBuilder);
    }
}
