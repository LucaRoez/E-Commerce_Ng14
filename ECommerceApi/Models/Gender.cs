using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Gender : ModelBase
    {
        [Required]
        public byte Id { get; set; }

        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
    }
}
