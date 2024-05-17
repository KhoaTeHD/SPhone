using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class User : IdentityUser<int>
    {
        public User()
        {
            CartItems = new HashSet<CartItem>();
            DeliveryAddresses = new HashSet<DeliveryAddress>();
            Notifications = new HashSet<Notification>();
            Reviews = new HashSet<Review>();
            Trackers = new HashSet<Tracker>();
            ProductVariations = new HashSet<ProductVariation>();
        }


        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<DeliveryAddress> DeliveryAddresses { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Tracker> Trackers { get; set; }
        public virtual ICollection<ProductVariation> ProductVariations { get; set; }
    }
}
