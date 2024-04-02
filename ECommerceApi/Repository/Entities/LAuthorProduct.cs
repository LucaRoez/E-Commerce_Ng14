using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.Repository.Entities
{
    public class LAuthorProduct
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This is a mandatory field.")]
        public short AuthorId { get; set; }

        [Required(ErrorMessage = "This is a mandatory field.")]
        public long ProductId { get; set; }

        public virtual DAuthor? AuthorNavigation { get; set; }

        public virtual DProduct? ProductNavigation { get; set;}
    }
}
