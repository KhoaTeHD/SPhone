using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("Cart_Item")]
    public class CartItem
    {
        [Key]
        public string Id { get; set; } = null!;
        public int? UserId { get; set; }
        public int? ProductVariationId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public virtual ProductVariation? ProductVariation { get; set; }
        public virtual User? User { get; set; }
    }
}
