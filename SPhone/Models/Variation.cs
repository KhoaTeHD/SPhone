using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class Variation
    {
        public Variation()
        {
            VariationOptions = new HashSet<VariationOption>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<VariationOption> VariationOptions { get; set; }
    }
}
