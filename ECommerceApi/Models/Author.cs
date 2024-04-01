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
        [MaxLength(50)]
        public string? Presentation { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(250)]
        public string Password { get; set; }

        public long? ReviewId { get; set; }
    }
}
