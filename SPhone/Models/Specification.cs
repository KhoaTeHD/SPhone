using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class Specification
    {
        public Specification()
        {
            SpecificationOptions = new HashSet<SpecificationOption>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<SpecificationOption> SpecificationOptions { get; set; }
    }
}
