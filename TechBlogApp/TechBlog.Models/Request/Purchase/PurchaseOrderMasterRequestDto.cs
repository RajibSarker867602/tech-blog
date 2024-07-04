using LeadingEdgeServer.Models.Entity.Common;
using LeadingEdgeServer.Models.Entity.Inventory;
using LeadingEdgeServer.Models.Entity.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Purchase
{
    public record PurchaseOrderMasterRequestDto
    {
        public Guid? Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid CurrencyId { get; set; }
        public Double ConvertionRate { get; set; }
        public Guid? ReferenceId { get; set; }
        public int PaymentMode { get; set; }
        public int TransactionMode { get; set; }
        public int? ShipmentMode { get; set; }
        public Guid? StoreId { get; set; }
        public ICollection<PurchaserOrderDetailsRequestDto> PurchaseOrderDetails { get; set; }
    }
}
