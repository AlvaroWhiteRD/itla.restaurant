namespace Resturant.Domain.Models;

public class ProductoAddModel
{
    public int Id { get; set; }

    public string Qr { get; set; }

    public string Descripcion { get; set; }

    public int Stock { get; set; }

    public string UrlImagen { get; set; }

    public decimal Precio { get; set; }
}
