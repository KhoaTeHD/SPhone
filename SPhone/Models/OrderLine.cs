using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    public partial class OrderLine
    {
        [Key, Column(Order = 0)]
        public int OrderId { get; set; }
        [Key, Column(Order = 1)]
        public int ProductVariationId { get; set; }
        public int? Quanty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }
        public bool? Reviewed { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual ProductVariation ProductVariation { get; set; } = null!;
    }
}
