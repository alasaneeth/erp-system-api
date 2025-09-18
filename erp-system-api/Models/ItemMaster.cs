using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace erp_system_api.Models
{
    [Table("item_masters")]

    public class ItemMaster : AuditableEntity
    {
        [Required]
        public long Code { get; set; }

        [MaxLength(50)]
        public string? ReferenceCode { get; set; }
        [MaxLength(100)]
        public string? Barcode { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public string? Description { get; set; }

        public long CategoryCode { get; set; }
        public long? SubCategoryCode { get; set; }
        public long? BrandCode { get; set; }
        public long? SizeCode { get; set; }

        [Precision(18, 2)]

        public decimal WholesalePrice { get; set; } = 0;
        [Precision(18, 2)]

        public decimal RetailPrice { get; set; } = 0;

        [Precision(18, 2)]

        public decimal CostPrice { get; set; } = 0;
        public bool IsActive { get; set; } = true;

        [ForeignKey(nameof(CategoryCode))]
        public virtual ItemCategory Category { get; set; }

        [ForeignKey(nameof(SubCategoryCode))]
        public virtual ItemSubCategory SubCategory { get; set; }

        [ForeignKey(nameof(BrandCode))]
        public virtual ItemBrand Brand { get; set; }

        [ForeignKey(nameof(SizeCode))]
        public virtual ItemSize Size { get; set; }

        public virtual ICollection<ItemImage> Images { get; set; }
    }
}
