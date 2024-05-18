using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("Specification")]
    public class Specification
    {

        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<SpecificationOption> SpecificationOptions { get; set; }
    }
}
