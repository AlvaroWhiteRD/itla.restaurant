using Resturant.Domain.Entities;
using Resturant.Domain.Models;
namespace Resturant.Domain.Extentions;

public static class CategoryAddModelExtensions
{
    public static Categoria ToCategory(this CategoryAddModel model)
    {
        return new Categoria
        {
            Descripcion = model.Descripcion,
            Id = model.Id,
        };
    }
}

public static class CategoryAddModelRevertExtensions
{
    public static CategoryAddModel ToRevert(this Categoria model)
    {
        return new CategoryAddModel
        {
            Descripcion = model.Descripcion,
            Id = model.Id,
        };
    }
}
