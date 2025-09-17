using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace erp_system_api.Models
{
    [Table("users")]

    public class Users:AuditableEntity
    {
      
        [Required]
        public string UserId { get; set; }

        public long? StockLocationCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; } = null!;  

        [Required]
        [MaxLength(255)]
        public string Password { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string UserRole { get; set; } = null!;

    
    }
}
