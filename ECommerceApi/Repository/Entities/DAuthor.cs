using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.Repository.Entities;

public partial class DAuthor : EntityBase
{
    public short? Id { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(20, ErrorMessage = "It can not have more than 20 characters.")]
    public string AuthorName { get; set; }

    [MaxLength(50, ErrorMessage = "It can not have more than 50 characters.")]
    public string? Presentation { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(80, ErrorMessage = "It can not have more than 80 characters.")]
    [RegularExpression("^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,5}$\r\n", ErrorMessage = "The information required is an email, please follow that format.")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(250, ErrorMessage = "It can not have more than 250 characters.")]
    public string Password { get; set; } = null!;
}
