using System;
using System.Collections.Generic;

namespace E_Commerce.Models;

public partial class CCurrency
{
    public byte Id { get; set; }

    public string Symbol { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Issuer { get; set; }

    public virtual ICollection<DProduct> DProducts { get; } = new List<DProduct>();
}
