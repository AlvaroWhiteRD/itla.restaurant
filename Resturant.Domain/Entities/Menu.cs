using Resturant.Domain.Core;

namespace Resturant.Domain.Entities;

public class Menu : BaseEntity
{
    public string Descripcion { get; set; }
    public int? IdMenuPadre { get; set; }
    public string Icono { get; set; }
    public string Controlador { get; set; }
    public string PaginaAccion { get; set; }
}
