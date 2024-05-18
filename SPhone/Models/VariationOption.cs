using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("VariationOption")]
    public class VariationOption
    {

        [Key]
        public int Id { get; set; }
        public int? VariationId { get; set; }
        public string? Value { get; set; }

        public virtual Variation? Variation { get; set; }

        public virtual ICollection<ProductVariation> ProductVariations { get; set; }
    }
}
