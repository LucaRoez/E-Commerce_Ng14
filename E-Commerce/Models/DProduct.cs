using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models;

public partial class DProduct
{
    [Key]
    public long Id { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(50, ErrorMessage = "It can not have more than 50 characters.")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(5000, ErrorMessage = "It can not have more than 5000 characters.")]
    public string Description { get; set; } = null!;

    public decimal? Price { get; set; }

    public byte? CurrencyId { get; set; }

    public decimal? Discount { get; set; }

    public short? QuantityAvailable { get; set; }

    public short SalesAmount { get; set; }

    public decimal? Rate { get; set; }

    public int Visits { get; set; }

    public byte? CategoryId { get; set; }

    public byte? GenderId { get; set; }

    public DateTime CreationDate { get; set; }

    public virtual CCategory? Category { get; set; }

    public virtual CCurrency? Currency { get; set; }

    public virtual CGender? Gender { get; set; }
}
