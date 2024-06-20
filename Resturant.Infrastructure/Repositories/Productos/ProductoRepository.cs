using Resturant.Domain.Entities;
using Resturant.Domain.Interfaces.Products;
using Resturant.Infrastructure.Context;
using Resturant.Infrastructure.Data;

namespace Resturant.Infrastructure.Repositories.Productos;

public class ProductoRepository : BaseRepository<Producto>, IProduct
{
    private readonly RestaurantContext _context;
    public ProductoRepository(RestaurantContext context) : base(context)
    {
        _context = context;
    }
}
