using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Currency : ModelBase
    {
        [Required]
        [MaxLength(5)]
        public string Symbol { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string? Issuer { get; set; }
    }
}
