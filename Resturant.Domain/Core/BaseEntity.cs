using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Resturant.Domain.Core;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        CreatedDate = DateTime.Now;
        CreatedUser = "default";
        Active = true;
        Deleted = false;
    }

    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public bool Active { get; set; }

    public bool? Deleted { get; set; }

    [Required]
    [StringLength(30)]
    public string CreatedUser { get; set; }

    [Required]
    public DateTime CreatedDate { get; set; }

    [StringLength(30)]
    public string? UpdatedUser { get; set; }
    public string? DeletedUser { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}
