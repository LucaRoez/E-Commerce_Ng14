using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Repository.Entities;

public partial class CGender : EntityBase
{
    [Key]
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DProduct> DProducts { get; } = new List<DProduct>();
}
