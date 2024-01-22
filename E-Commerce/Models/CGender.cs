using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public partial class CGender
{
    [Key]
    public byte Id { get; set; }

    [Required]
    [MaxLength(5)]
    public string Name { get; set; } = null!;

    public virtual ICollection<DProduct> DProducts { get; } = new List<DProduct>();
}
