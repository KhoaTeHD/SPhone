using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("Payment")]
    public class Payment
    {

        [Key]
        public int Id { get; set; }
        public string? PaymentName { get; set; }
        public string? Value { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
