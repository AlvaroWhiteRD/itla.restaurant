using Resturant.Domain.Entities;
using Resturant.Domain.Models;

namespace Resturant.Domain.Extensions;

public static class ProductAddModelExtensions
{
    public static Producto ToProduct(this ProductoAddModel model)
    {
        return new Producto
        {
            Descripcion = model.Descripcion,
            Id = model.Id,
            Qr = model.Qr,
            Stock = model.Stock,
            UrlImagen = model.UrlImagen,
            Precio = model.Precio,
        };
    }
}

public static class ProductAddModelRevertExtensions
{
    public static ProductoAddModel ToRevert(this Producto model)
    {
        return new ProductoAddModel
        {
            Descripcion = model.Descripcion,
            Id = model.Id,
            Qr = model.Qr,
            Stock = model.Stock,
            UrlImagen = model.UrlImagen,
            Precio = model.Precio,
        };
    }
}
