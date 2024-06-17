﻿namespace Resturant.Domain.Entities;

public class Negocio
{
    public int Id { get; set; }
    public string UrlLogo { get; set; }
    public string NombreLogo { get; set; }
    public string NumeroDocumento { get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public decimal? PorcentajeImpuesto { get; set; }
    public string SimboloMoneda { get; set; }
    public DateTime FechaRegistro { get; set; }
    public int IdUsuarioCreacion { get; set; }
    public DateTime? FechaMod { get; set; }
    public int? IdUsuarioMod { get; set; }
    public int? IdUsuarioElimino { get; set; }
    public DateTime? FechaElimino { get; set; }
    public bool Eliminado { get; set; }
}
