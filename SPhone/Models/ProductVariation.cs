using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    public partial class ProductVariation
    {
        public ProductVariation()
        {
            CartItems = new HashSet<CartItem>();
            OrderLines = new HashSet<OrderLine>();
            Reviews = new HashSet<Review>();
            Options = new HashSet<VariationOption>();
            SpecOptions = new HashSet<SpecificationOption>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public string? Image { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountedPrice { get; set; }
        public bool IsActive { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<VariationOption> Options { get; set; }
        public virtual ICollection<SpecificationOption> SpecOptions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
