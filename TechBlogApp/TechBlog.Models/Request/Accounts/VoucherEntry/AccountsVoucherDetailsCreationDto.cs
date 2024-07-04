using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.NewFolder.VoucherEntry
{
    public class AccountsVoucherDetailsCreationDto
    {
        public Guid? Id { get; set; }
        public Guid? VoucherMasterId { get; set; }
        [Required(ErrorMessage = "Chart of account is required")]
        public Guid COAId { get; set; }
        public Guid? TransactionId { get; set; }
        public string? ChequeNumber { get; set; }
        public DateTime? ChequeDate { get; set; }
        //public int VoucherMode { get; set; }
        public double? DRAmount { get; set; } = 0;
        public double? CRAmount { get; set; } = 0;
        public string? VoucherNarration { get; set; }
        public double? CurrencyAmount { get; set; } = 0;
        public string? COAType { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? ParentLedgerId { get; set; }
    }
}
