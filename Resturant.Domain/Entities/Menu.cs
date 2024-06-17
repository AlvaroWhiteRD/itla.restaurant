namespace Resturant.Domain.Entities;

public class Menu
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public int? IdMenuPadre { get; set; }
    public string Icono { get; set; }
    public string Controlador { get; set; }
    public string PaginaAccion { get; set; }
    public bool? EsActivo { get; set; }
    public DateTime FechaRegistro { get; set; }
    public int IdUsuarioCreacion { get; set; }
    public DateTime? FechaMod { get; set; }
    public int? IdUsuarioMod { get; set; }
    public int? IdUsuarioElimino { get; set; }
    public DateTime? FechaElimino { get; set; }
    public bool Eliminado { get; set; }
}
