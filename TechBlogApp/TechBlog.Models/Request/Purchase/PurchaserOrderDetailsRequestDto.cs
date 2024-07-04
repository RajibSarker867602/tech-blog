using LeadingEdgeServer.Models.Entity.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Purchase
{
    public record PurchaserOrderDetailsRequestDto
    {
        public Guid? Id { get; set; }
        public Guid? ItemRequisitionMasterId { get; set; }
        public Guid PurchaseOrderId { get; set; }
        public Guid ItemId { get; set; }
        public Guid UnitId { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string? Description { get; set; }
    }
}
