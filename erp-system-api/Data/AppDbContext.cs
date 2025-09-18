using erp_system_api.Models;
using Microsoft.EntityFrameworkCore;


namespace erp_system_api.Data

{
    public class AppDbContext : DbContext
    {

      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
      public DbSet<Users> users { get; set; }
      public DbSet<CustomerType> CustomerTypes { get; set; }
      public DbSet<Customer> Customers { get; set; }

      public DbSet<ItemCategory> ItemCategories { get; set; }
      public DbSet<ItemSubCategory> ItemSubCategories { get; set; }
      public DbSet<ItemBrand> ItemBrands { get; set; }
      public DbSet<ItemSize> ItemSizes { get; set; }
      public DbSet<ItemMaster> ItemMasters { get; set; }
      public DbSet<ItemImage> ItemImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CreditLimit).HasPrecision(18, 2);
                entity.Property(e => e.InvoiceTotal).HasPrecision(18, 2);
                entity.Property(e => e.ReceivedAmount).HasPrecision(18, 2);
                entity.Property(e => e.CreditAmount).HasPrecision(18, 2);
                entity.Property(e => e.ReturnAmount).HasPrecision(18, 2);
                entity.Property(e => e.ChequeReturnAmount).HasPrecision(18, 2);
            });

            // Configure decimals for ItemMaster
            modelBuilder.Entity<ItemMaster>(entity =>
            {
                entity.Property(e => e.WholesalePrice).HasPrecision(18, 2);
                entity.Property(e => e.RetailPrice).HasPrecision(18, 2);
                entity.Property(e => e.CostPrice).HasPrecision(18, 2);
            });

            // Relationships for ItemMaster (as you had)
            modelBuilder.Entity<ItemSubCategory>()
                .HasOne(sc => sc.Category)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(sc => sc.CategoryCode)
                .HasPrincipalKey(c => c.Code)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ItemMaster>()
                .HasOne(im => im.Category)
                .WithMany(c => c.Items)
                .HasForeignKey(im => im.CategoryCode)
                .HasPrincipalKey(c => c.Code)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ItemMaster>()
                .HasOne(im => im.SubCategory)
                .WithMany(sc => sc.Items)
                .HasForeignKey(im => im.SubCategoryCode)
                .HasPrincipalKey(sc => sc.Code)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ItemMaster>()
                .HasOne(im => im.Brand)
                .WithMany(b => b.Items)
                .HasForeignKey(im => im.BrandCode)
                .HasPrincipalKey(b => b.Code)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ItemMaster>()
                .HasOne(im => im.Size)
                .WithMany(s => s.Items)
                .HasForeignKey(im => im.SizeCode)
                .HasPrincipalKey(s => s.Code)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ItemImage>()
                .HasOne(ii => ii.Item)
                .WithMany(im => im.Images)
                .HasForeignKey(ii => ii.ItemCode)
                .HasPrincipalKey(im => im.Code)
                .OnDelete(DeleteBehavior.Cascade);
        }




    }
}
