using erp_system_api.Models;
using Microsoft.EntityFrameworkCore;


namespace erp_system_api.Data

{
    public class AppDbContext : DbContext
    {

      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
      public DbSet<Users> users { get; set; }
        
       
    }
}
