using LeadingEdgeServer.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.VoucherEntry
{
    public class AccountsVoucherMasterResponseDto
    {
        public AccountsVoucherMasterResponseDto()
        {
            AccountsVoucherDetails = new List<AccountsVoucherDetailResponseDto>();
        }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? DonorId { get; set; }
        public Guid? DepartmentId { get; set; }
        public string VoucherType { get; set; }
        public string? VoucherNo { get; set; }
        public DateTime VoucherDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Guid? CurrencyId { get; set; }
        public Double? ConvertionRate { get; set; }
        public string Narration { get; set; }
        public string? VoucherAttachmentUrl { get; set; }
        public ApprovalTypeEnum VoucherStatus { get; set; }
        public string? ReferenceNumber { get; set; }
        public Guid? FiscalYearId { get; set; }
        public Guid? ReferenceVoucherNumber { get; set; }
        public bool IsSynced { get; set; } = false;
        public bool IsModulesTransaction { get; set; } = false;
        public ICollection<AccountsVoucherDetailResponseDto> AccountsVoucherDetails { get; set; }
    }

    public class AccountsVoucherDetailResponseDto
    {
        public Guid Id { get; set; }
        public Guid? VoucherMasterId { get; set; }
        public Guid COAId { get; set; }
        public Guid? TransactionId { get; set; }
        public string? ChequeNumber { get; set; }
        public DateTime? ChequeDate { get; set; }
        public double? DRAmount { get; set; } = 0;
        public double? CRAmount { get; set; } = 0;
        public string? VoucherNarration { get; set; }
        public int VoucherMode { get; set; }
        public double? CurrencyAmount { get; set; } = 0;
        public string? COAType { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? ParentLedgerId { get; set; }
    }
}
