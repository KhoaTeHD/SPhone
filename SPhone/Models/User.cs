using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("User")]
    public class User : IdentityUser<int>
    {
        public DateTime? BirthDay { get; set; }
        public bool Gender { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<DeliveryAddress> DeliveryAddresses { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Tracker> Trackers { get; set; }

        public virtual ICollection<Product> LovedProducts { get; set; }  
    }
}
