using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace erp_system_api.Models
{
    public class ItemImage : AuditableEntity
    {
        [Required]
        public long Code { get; set; }

        [ForeignKey(nameof(Item))]
        public long ItemCode { get; set; }
        [MaxLength(500)]
        public string FilePath { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual ItemMaster Item { get; set; }
    }
}
