using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public partial class CCurrency
{
    [Key]
    public byte Id { get; set; }

    [Required]
    [MaxLength(5)]
    public string Symbol { get; set; } = null!;

    [Required]
    [MaxLength(20)]
    public string Name { get; set; } = null!;

    [MaxLength(20)]
    public string? Issuer { get; set; }

    public virtual ICollection<DProduct> DProducts { get; } = new List<DProduct>();
}
