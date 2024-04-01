﻿namespace ECommerceApi.Repository.Entities;

public partial class DProduct : EntityBase
{
    public long? Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
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
    public virtual CCategory? Category { get; set; }
    public virtual CCurrency? Currency { get; set; }
    public virtual CGender? Gender { get; set; }
    public long? PresentationImageId { get; set; }
    public long? SecondImageId { get; set; }
    public long? ThirdImageId { get; set; }
    public long? FourthImageId { get; set; }
    public long? FifthImageId { get; set; }
    public long? SixthImageId { get; set; }
    public long? ReviewId { get; set; }

}
