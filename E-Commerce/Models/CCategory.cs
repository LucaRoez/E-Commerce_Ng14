using System;
using System.Collections.Generic;

namespace E_Commerce.Models;

public partial class CCategory
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DProduct> DProducts { get; } = new List<DProduct>();
}
