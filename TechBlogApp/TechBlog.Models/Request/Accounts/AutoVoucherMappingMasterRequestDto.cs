using LeadingEdgeServer.Models.Entity.Accounts.AutoVoucherMapping;
using LeadingEdgeServer.Models.Entity.Accounts;
using LeadingEdgeServer.Models.Entity.Common;
using LeadingEdgeServer.Models.Entity.Inventory;
using LeadingEdgeServer.Models.Enum.AutoVoucher;
using LeadingEdgeServer.Models.Enum.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public record AutoVoucherMappingMasterRequestDto
    {
        public AutoVoucherMappingMasterRequestDto()
        {
            AutoVoucherMappingDetails = new List<AutoVoucherMappingDetailRequestDto>();
        }
        public Guid? Id { get; set; }
        public Guid ProjectId { get; set; }
        [Required]
        public string VoucherType { get; set; }
        [Required]
        public ConfigurationTypeEnum ConfigurationType { get; set; }
        public TransactionModeEnum TransactionMode { get; set; }
        public PaymentModeEnum PaymentMode { get; set; }
        public bool IsVisiable { get; set; }
        public bool IsActive { get; set; }
        public ICollection<AutoVoucherMappingDetailRequestDto> AutoVoucherMappingDetails { get; set; }
    }

    public record AutoVoucherMappingDetailRequestDto
    {
        public Guid? Id { get; set; }
        public Guid? AutoVoucherMappingMasterId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid COAId { get; set; }
        public COACrDrTypeEnum CrDrType { get; set; }
        public string? COAType { get; set; }
    }
}
