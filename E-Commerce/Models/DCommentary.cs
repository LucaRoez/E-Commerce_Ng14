using System;
using System.Collections.Generic;

namespace E_Commerce.Models;

public partial class DCommentary
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Body { get; set; } = null!;

    public bool IsEdited { get; set; }

    public int Likes { get; set; }

    public int Dislikes { get; set; }
}
