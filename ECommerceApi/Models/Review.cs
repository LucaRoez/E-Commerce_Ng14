using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.Models
{
    public class Review : ModelBase
    {
        [Key]
        public long? Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Author { get; set; }

        [Required]
        public short? AuthorId { get; set; }

        [Required]
        [MaxLength(5000)]
        public string Body { get; set; }

        [Required]
        public decimal Rate {  get; set; }

        [Required]
        [MaxLength(50)]
        public string Product {  get; set; }

        [Required]
        public long? ProductId { get; set; }
    }
}
