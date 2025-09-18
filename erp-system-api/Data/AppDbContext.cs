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
        }



    }
}
