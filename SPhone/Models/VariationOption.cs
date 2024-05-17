using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class VariationOption
    {
        public VariationOption()
        {
            ProductVariations = new HashSet<ProductVariation>();
        }

        public int Id { get; set; }
        public int? VariationId { get; set; }
        public string? Value { get; set; }

        public virtual Variation? Variation { get; set; }

        public virtual ICollection<ProductVariation> ProductVariations { get; set; }
    }
}
