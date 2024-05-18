using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("SpecificationOption")]
    public class SpecificationOption
    {

        [Key]
        public int Id { get; set; }
        public int? SpecId { get; set; }
        public string? Value { get; set; }

        public virtual Specification? Spec { get; set; }

        public virtual ICollection<ProductVariation> ProductVariations { get; set; }
    }
}
