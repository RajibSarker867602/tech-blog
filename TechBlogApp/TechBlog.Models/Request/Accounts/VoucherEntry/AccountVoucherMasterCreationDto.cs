using LeadingEdgeServer.Models.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.NewFolder.VoucherEntry
{
    public class AccountVoucherMasterCreationDto
    {
        public AccountVoucherMasterCreationDto()
        {
            AccountsVoucherDetails = new List<AccountsVoucherDetailsCreationDto>();
        }

        public Guid? Id { get; set; }
        //[Required(ErrorMessage = "Project id is required")]
        //public Guid ProjectId { get; set; }
        public Guid? DonorId { get; set; }
        public Guid? DepartmentId { get; set; }
        [Required(ErrorMessage = "Voucher type is required")]
        public string VoucherType { get; set; }
        public string? VoucherNo { get; set; }
        [Required(ErrorMessage = "Voucher Date is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Voucher date should be date time only")]
        public DateTime VoucherDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public Guid? CurrencyId { get; set; }
        public Double? ConvertionRate { get; set; }
        [Required(ErrorMessage = "Narration is required")]
        public string Narration { get; set; }
        public IFormFile? VoucherAttachment { get; set; }
        public string? VoucherAttachmentUrl { get; set; }
        [Required(ErrorMessage = "Voucher status is required")]
        public ApprovalTypeEnum VoucherStatus { get; set; }
        public string? ReferenceNumber { get; set; }
        public Guid? FiscalYearId { get; set; }
        public Guid? ReferenceVoucherNumber { get; set; }
        public bool IsSynced { get; set; } = false;
        public bool IsModulesTransaction { get; set; } = false;
        public ICollection<AccountsVoucherDetailsCreationDto> AccountsVoucherDetails { get; set; }
    }
}
