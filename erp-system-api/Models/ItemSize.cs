using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace erp_system_api.Models
{
    [Table("item_sizes")]

    public class ItemSize : AuditableEntity
    {
        [Required]
        public long Code { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual ICollection<ItemMaster> Items { get; set; }
    }
}
