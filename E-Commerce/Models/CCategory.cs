using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public partial class CCategory
{
    [Key]
    public byte Id { get; set; }

    [Required]
    [MaxLength(10)]
    public string Name { get; set; } = null!;

    public virtual ICollection<DProduct> DProducts { get; } = new List<DProduct>();
}
