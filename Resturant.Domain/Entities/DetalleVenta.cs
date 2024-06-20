using Resturant.Domain.Core;

namespace Resturant.Domain.Entities;

public class DetalleVenta : BaseEntity
{
    public int? VentaId { get; set; }
    public int? ProductoId { get; set; }
    public string MarcaProducto { get; set; }
    public string DescripcionProducto { get; set; }
    public string CategoriaProducto { get; set; }
    public int? Cantidad { get; set; }
    public decimal? Precio { get; set; }
    public decimal? Total { get; set; }
}
