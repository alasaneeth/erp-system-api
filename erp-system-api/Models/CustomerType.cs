using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace erp_system_api.Models
{
    [Table("customer_types")]
    public class CustomerType : AuditableEntity
    {
    
        [Required]
        [MaxLength(100)]
        public string Type { get; set; }

 
    }
}
