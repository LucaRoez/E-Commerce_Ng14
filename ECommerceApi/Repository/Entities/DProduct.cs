using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.Repository.Entities;

public partial class DProduct : EntityBase
{
    public long? Id { get; set; }

    [Required(ErrorMessage = "This is a mandatory field.")]
    [MaxLength(50, ErrorMessage = "It can not have more than 50 characters.")]
    public string Name { get; set; }

    [MaxLength(5000, ErrorMessage = "It can not have more than 50 characters.")]
    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? CurrencyId { get; set; }

    public decimal? Discount { get; set; }

    public short? QuantityAvailable { get; set; }

    public short SalesAmount { get; set; }

    public decimal? Rate { get; set; }

    public int Visits { get; set; }

    public byte CategoryId { get; set; }

    public byte GenderId { get; set; }

    public DateTime CreationDate { get; set; }

    public long? PresentationImageId { get; set; }

    public long? SecondImageId { get; set; }

    public long? ThirdImageId { get; set; }

    public long? FourthImageId { get; set; }

    public long? FifthImageId { get; set; }

    public long? SixthImageId { get; set; }

    public virtual CCategory? CategoryNavigation { get; set; }
    public virtual CCurrency? CurrencyNavigation { get; set; }
    public virtual CGender? GenderNavigation { get; set; }

}
