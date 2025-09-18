using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace erp_system_api.Models
{
    [Table("item_sub_categories")]

    public class ItemSubCategory : AuditableEntity
    {
        [Required]
        public long Code { get; set; }

        [ForeignKey(nameof(Category))]
        public long CategoryCode { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual ItemCategory Category { get; set; }
        public virtual ICollection<ItemMaster> Items { get; set; }
    }
}
