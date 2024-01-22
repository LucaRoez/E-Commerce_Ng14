using System;
using System.Collections.Generic;

namespace E_Commerce.Models;

public partial class DAuthor
{
    public short Id { get; set; }

    public string AuthorName { get; set; }

    public string? Presentation { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<DReview> DReviews { get; } = new List<DReview>();
}
