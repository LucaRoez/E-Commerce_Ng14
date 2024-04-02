namespace ECommerceApi.Repository.Entities;

public partial class CGender : EntityBase
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DProduct>? DProductsNavigation { get; set; }
}
