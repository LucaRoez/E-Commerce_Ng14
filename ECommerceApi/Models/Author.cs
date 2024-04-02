using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.Models
{
    public class Author : ModelBase
    {
        [Key]
        public short? Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string AuthorName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "It can not have more than 50 characters.")]
        public string? Presentation { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "It can not have more than 80 characters.")]
        [RegularExpression("^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,5}$\r\n", ErrorMessage = "The information required is an email, please follow that format.")]
        public string Email { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "It can not have more than 50 characters.")]
        [RegularExpression("^(?=.*[!#$%&*-+.,_])(?=.*\\d)(?=.*[A-Z]).*$", ErrorMessage = "At least one upper case, numeric digit and one special character is required.")]
        public string Password { get; set; }

        public ICollection<Product>? LinkedProducts { get; set; }

        public ICollection<Review>? LinkedReviews { get; set; }
    }
}
