using LeadingEdgeServer.Models.Common;
using LeadingEdgeServer.Models.Entity.Common;
using LeadingEdgeServer.Models.Entity.Inventory;
using LeadingEdgeServer.Models.Entity.Purchase;
using LeadingEdgeServer.Models.Enum.AutoVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Purchase
{
    public record PurchaseOrderMasterResponseDto
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public Guid CurrencyId { get; set; }
        public Double ConvertionRate { get; set; }
        public string? CurrencyName { get; set; }
        public string? AutoGenCode { get; set; }
        public Guid? ReferenceId { get; set; }
        public string? PaymentModeName => PaymentMode.GetEnumTitle(true);
        public string? TransactionModeName => TransactionMode.GetEnumTitle(true);
        public string? ShipmentMode { get; set; }
        public PaymentModeEnum PaymentMode { get; set; }
        public TransactionModeEnum TransactionMode { get; set; }
        public Guid? StoreId { get; set; }
        public string? StoreName { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string Description { get; set; }
        public ICollection<PurchaseOrderDetailsResponseDto> PurchaseOrderDetails { get; set; }
    }
}
