using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductVariations = new HashSet<ProductVariation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? CategoryId { get; set; }
        public string Avatar { get; set; } = null!;
        public int SumQty { get; set; }
        public bool IsActive { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<ProductVariation> ProductVariations { get; set; }
    }
}
