using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace erp_system_api.Models
{
    public class Customer : AuditableEntity
    {
        [MaxLength(50)]
        public string CustomCode { get; set; }

        [ForeignKey("CustomerType")]
        public int CustomerTypeId { get; set; }
        public CustomerType CustomerType { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string SecondName { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [Precision(18, 2)]
        public decimal CreditLimit { get; set; } = 0;

        [Precision(18, 2)]
        public decimal InvoiceTotal { get; set; } = 0;

        [Precision(18, 2)]
        public decimal ReceivedAmount { get; set; } = 0;

        [Precision(18, 2)]
        public decimal CreditAmount { get; set; } = 0;

        [Precision(18, 2)]
        public decimal ReturnAmount { get; set; } = 0;

        [Precision(18, 2)]
        public decimal ChequeReturnAmount { get; set; } = 0;

        public int CreditDays { get; set; } = 0;
    }
}
