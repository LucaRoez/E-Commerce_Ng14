namespace ECommerceApi.Repository.Entities;

public partial class CGender : EntityBase
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DProduct> DProducts { get; } = new List<DProduct>();
}
