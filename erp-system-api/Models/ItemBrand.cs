using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace erp_system_api.Models
{
    [Table("item_brands")]

    public class ItemBrand : AuditableEntity
    {
        [Required]
        public long Code { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual ICollection<ItemMaster> Items { get; set; }
    }
}
