using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            Orders = new HashSet<Order>();
        }

        public string Id { get; set; } = null!;
        public int? Value { get; set; }
        public bool? Unit { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
