using System;
using System.Collections.Generic;

namespace E_Commerce.Models;

public partial class DReview
{
    public long Id { get; set; }

    public string Author { get; set; } = null!;

    public short? AuthorId { get; set; }

    public string Body { get; set; } = null!;

    public decimal Rate { get; set; }

    public virtual DAuthor? AuthorNavigation { get; set; }
}
