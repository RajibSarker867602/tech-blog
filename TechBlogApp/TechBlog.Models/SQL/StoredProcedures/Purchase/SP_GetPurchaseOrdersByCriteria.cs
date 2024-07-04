using LeadingEdgeServer.Models.Common;
using LeadingEdgeServer.Models.Enum;
using LeadingEdgeServer.Models.Enum.AutoVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Purchase
{
    public record SP_GetPurchaseOrdersByCriteria
    {
        public int? SL { get; set; }
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public Guid? CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public double ConvertionRate { get; set; }
        public string AutoGenCode { get; set; }
        public Guid ReferenceId { get; set; }
        public PaymentModeEnum PaymentMode { get; set; }
        public string? PaymentModeName => PaymentMode.GetEnumTitle(true);
        public TransactionModeEnum TransactionMode { get; set; }
        public string? TransactionModeName => TransactionMode.GetEnumTitle(true);
        public int? ShipmentMode { get; set; }
        public string? ShipmentModeName { get; set; }
        public Guid? StoreId { get; set; }
        public string? StoreName { get; set; }
        public bool IsDeleted { get; set; }
        public double TotalPrice { get; set; }
        public double TotalLocalPrice { get; set; }
        public long RowNumber { get; set; }
        public ApprovalTypeEnum StatusId { get; set; }
        public string StatusName => this.StatusId.GetEnumTitle(true);
    }
}
