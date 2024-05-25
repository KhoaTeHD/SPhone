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

        public SPhoneContext()
        {
        }

        public SPhoneContext(DbContextOptions<SPhoneContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
            //optionsBuilder.UseSqlServer("Server=DangKhoa;Database=SPhone;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer("Data Source=HUNGTADASUKE\\MYSUPERASUS;Initial Catalog=SPhone;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProductVariation>()
                .HasMany(x => x.Options)
                .WithMany(y => y.ProductVariations)
                .UsingEntity(j => j.ToTable("ProductVariationOption"));

            builder.Entity<ProductVariation>()
                .HasMany(x => x.SpecOptions)
                .WithMany(y => y.ProductVariations)
                .UsingEntity(j => j.ToTable("ProductVariation_Spec_Option"));

            builder.Entity<User>()
                .HasMany(x => x.LovedProducts)
                .WithMany(y => y.Users)
                .UsingEntity(j => j.ToTable("LovedProduct"));

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
