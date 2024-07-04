using LeadingEdgeServer.Models.Common;
using LeadingEdgeServer.Models.Enum.AutoVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Purchase
{
    public record GetPurchaseOrderListForRemainingReceive_SP
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string PurchaseOrder { get; set; }
        public string? ItemReceive { get; set; }
        public PaymentModeEnum PaymentMode { get; set; }
        public string PaymentModeName => PaymentMode.GetEnumTitle(true);
        public TransactionModeEnum TransactionMode { get; set; }
        public string TransactionModeName => TransactionMode.GetEnumTitle(true);
        public Guid? TransactionId { get; set; }
        public float PoQuantity { get; set; }
        public float IrQuantity { get; set; }
        public float Remaining { get; set; }
    }
}
