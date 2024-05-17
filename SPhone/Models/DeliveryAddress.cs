using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class DeliveryAddress
    {
        public DeliveryAddress()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Ward { get; set; }
        public string? AddressLine { get; set; }
        public int? UserId { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
