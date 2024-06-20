using Resturant.Domain.Entities;
using Resturant.Domain.Interfaces.Categorys;
using Resturant.Infrastructure.Context;

namespace Resturant.Infrastructure.Repositories.Categorys;

public class CategoryRepository : BaseRepository<Categoria>, ICategory
{
    private readonly RestaurantContext _context;
    public CategoryRepository(RestaurantContext context) : base(context)
    {
        _context = context;
    }
}
