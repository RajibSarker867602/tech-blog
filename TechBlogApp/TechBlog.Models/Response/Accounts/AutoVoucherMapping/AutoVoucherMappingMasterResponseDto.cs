using LeadingEdgeServer.Models.Common;
using LeadingEdgeServer.Models.Entity.Accounts;
using LeadingEdgeServer.Models.Entity.Common;
using LeadingEdgeServer.Models.Enum.AutoVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.AutoVoucherMapping
{
    public class AutoVoucherMappingMasterResponseDto
    {
        public int? SL { get; set; }
        public Guid? Id { get; set; }
        public Guid ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string VoucherType { get; set; }
        public ConfigurationTypeEnum ConfigurationType { get; set; }
        public string ConfigurationTypeName => ConfigurationType.GetEnumTitle(true);
        public TransactionModeEnum TransactionMode { get; set; }
        public string TransactionModeName => TransactionMode.GetEnumTitle(true);
        public PaymentModeEnum PaymentMode { get; set; }
        public string PaymentModeName => PaymentMode.GetEnumTitle(true);
        public bool IsVisiable { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
    }
}
