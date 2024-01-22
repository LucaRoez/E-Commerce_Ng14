using System;
using System.Collections.Generic;

namespace E_Commerce.Models;

public partial class DImage
{
    public long Id { get; set; }

    public string Src { get; set; } = null!;

    public string? Alt { get; set; }

    public int Width { get; set; }

    public int Heigth { get; set; }
}
