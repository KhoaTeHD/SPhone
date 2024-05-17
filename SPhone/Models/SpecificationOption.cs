using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class SpecificationOption
    {
        public SpecificationOption()
        {
            ProductVariations = new HashSet<ProductVariation>();
        }

        public int Id { get; set; }
        public int? SpecId { get; set; }
        public string? Value { get; set; }

        public virtual Specification? Spec { get; set; }

        public virtual ICollection<ProductVariation> ProductVariations { get; set; }
    }
}
