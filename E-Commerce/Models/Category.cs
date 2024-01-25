using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Category : ModelBase
    {
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
