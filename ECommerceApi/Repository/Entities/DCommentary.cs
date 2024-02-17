using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Repository.Entities;

public partial class DCommentary
{
    public long Id { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(20, ErrorMessage = "It can not have more than 20 characters.")]
    public string UserName { get; set; } = null!;

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(5000, ErrorMessage = "It can not have more than 5000 characters.")]
    public string Body { get; set; } = null!;

    public bool IsEdited { get; set; }

    public int Likes { get; set; }

    public int Dislikes { get; set; }
}
