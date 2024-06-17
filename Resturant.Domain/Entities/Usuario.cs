namespace Resturant.Domain.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }
    public int? IdRol { get; set; }
    public string UrlFoto { get; set; }
    public string NombreFoto { get; set; }
    public string Clave { get; set; }
    public bool? EsActivo { get; set; }
    public DateTime FechaRegistro { get; set; }
    public int IdUsuarioCreacion { get; set; }
    public DateTime? FechaMod { get; set; }
    public int? IdUsuarioMod { get; set; }
    public int? IdUsuarioElimino { get; set; }
    public DateTime? FechaElimino { get; set; }
    public bool Eliminado { get; set; }
}
