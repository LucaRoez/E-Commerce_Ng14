﻿using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.Models
{
    public class Currency : ModelBase
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        [MaxLength(5)]
        public string Symbol { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string? Issuer { get; set; }
    }
}
