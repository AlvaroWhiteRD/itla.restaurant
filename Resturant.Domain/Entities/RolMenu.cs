using Resturant.Domain.Core;

namespace Resturant.Domain.Entities;

public class RolMenu : BaseEntity
{
    public int? IdRol { get; set; }
    public int? IdMenu { get; set; }
}
