using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.Models
{
    public class Category : ModelBase
    {
        [Required]
        public byte Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
