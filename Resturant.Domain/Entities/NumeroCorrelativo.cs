using Resturant.Domain.Core;

namespace Resturant.Domain.Entities;

public class NumeroCorrelativo : BaseEntity
{
    public int? UltimoNumero { get; set; }
    public int? CantidadDigitos { get; set; }
    public string Gestion { get; set; }
}
