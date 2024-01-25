using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Repository.Entities;

public partial class CCurrency : EntityBase
{
    [Key]
    public byte Id { get; set; }

    public string Symbol { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Issuer { get; set; }

    public virtual ICollection<DProduct> DProducts { get; } = new List<DProduct>();
}
