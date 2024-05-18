using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("Order")]
    public class Order
    {

        [Key]
        public int Id { get; set; }
        public int? PaymentId { get; set; }
        public string? VoucherId { get; set; }
        public int? DeliveryAddressId { get; set; }
        public int? UserId { get; set; }
        public DateTime? OrderDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderTotal { get; set; }
        public string? OrderStatus { get; set; }
        public bool? IsActive { get; set; }

        public virtual DeliveryAddress? DeliveryAddress { get; set; }
        public virtual Payment? Payment { get; set; }
        public virtual Voucher? Voucher { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
