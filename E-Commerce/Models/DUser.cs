using System;
using System.Collections.Generic;

namespace E_Commerce.Models;

public partial class DUser
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
