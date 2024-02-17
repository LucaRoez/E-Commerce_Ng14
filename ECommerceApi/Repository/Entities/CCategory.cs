using System.ComponentModel.DataAnnotations;

namespace ECommerce.Repository.Entities;

public class CCategory : EntityBase
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DProduct> DProducts { get; } = new List<DProduct>();
}
