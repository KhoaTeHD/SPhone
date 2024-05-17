using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? PaymentName { get; set; }
        public string? Value { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
