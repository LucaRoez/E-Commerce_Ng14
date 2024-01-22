﻿using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public partial class DImage
{
    [Key]
    public long Id { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(250, ErrorMessage = "It can not have more than 250 characters.")]
    public string Src { get; set; } = null!;

    public string? Alt { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    public int Width { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    public int Heigth { get; set; }
}
