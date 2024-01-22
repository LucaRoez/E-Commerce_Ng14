﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public partial class DReview
{
    [Key]
    public long Id { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(20, ErrorMessage = "It can not have more than 20 characters.")]
    public string Author { get; set; } = null!;

    public short? AuthorId { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(5000, ErrorMessage = "It can not have more than 5000 characters.")]
    public string Body { get; set; } = null!;

    [Required(ErrorMessage = "This is a mandatory field.")]
    public decimal Rate { get; set; }

    public virtual DAuthor? AuthorNavigation { get; set; }
}
