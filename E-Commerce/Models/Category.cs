using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Category : ModelBase
    {
        public byte Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
