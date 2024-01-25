using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Gender : ModelBase
    {
        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
    }
}
