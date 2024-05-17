using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SPhone.Models
{
    public partial class SPhoneContext : IdentityDbContext<User, Roles, int>
    {

        public virtual DbSet<CartItem> CartItems { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<DeliveryAddress> DeliveryAddresses { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderLine> OrderLines { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductVariation> ProductVariations { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<Specification> Specifications { get; set; } = null!;
        public virtual DbSet<SpecificationOption> SpecificationOptions { get; set; } = null!;
        public virtual DbSet<Tracker> Trackers { get; set; } = null!;
        public virtual DbSet<Variation> Variations { get; set; } = null!;
        public virtual DbSet<VariationOption> VariationOptions { get; set; } = null!;
        public virtual DbSet<Voucher> Vouchers { get; set; } = null!;

        public SPhoneContext(DbContextOptions<SPhoneContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<OrderLine>().HasKey(x => new {x.OrderId, x.ProductVariationId});

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
        }
    }
}
