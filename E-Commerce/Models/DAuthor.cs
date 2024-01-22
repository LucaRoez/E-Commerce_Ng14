using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public partial class DAuthor
{
    [Key]
    public short Id { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(20, ErrorMessage = "It can not have more than 20 characters.")]
    public string AuthorName { get; set; }

    [MaxLength(50, ErrorMessage = "It can not have more than 50 characters.")]
    public string? Presentation { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(50, ErrorMessage = "It can not have more than 50 characters.")]
    [RegularExpression("^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,5}$\r\n", ErrorMessage = "The information required is an email, please follow that format.")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(250, ErrorMessage = "It can not have more than 250 characters.")]
    [RegularExpression("^(?=.*[!#$%&*-+.,_])(?=.*\\d)(?=.*[A-Z]).*$", ErrorMessage = "At least one upper case, numeric digit and one special character is required.")]
    public string Password { get; set; } = null!;

    public virtual ICollection<DReview> DReviews { get; } = new List<DReview>();
}
