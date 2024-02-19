namespace ECommerceApi.Repository.Entities;

public partial class CCurrency : EntityBase
{
    public int? Id { get; set; }

    public string Symbol { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Issuer { get; set; }

    public virtual ICollection<DProduct> DProducts { get; } = new List<DProduct>();
}
