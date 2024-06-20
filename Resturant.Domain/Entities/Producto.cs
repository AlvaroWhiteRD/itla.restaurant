using Resturant.Domain.Core;

namespace Resturant.Domain.Entities;

public class Producto : BaseEntity
{
    public string Qr { get; set; }
    //public string? Marca { get; set; }
    public string Descripcion { get; set; }
    //public int? IdCategoria { get; set; }
    public int Stock { get; set; }
    public string UrlImagen { get; set; }
    public decimal Precio { get; set; }
}
