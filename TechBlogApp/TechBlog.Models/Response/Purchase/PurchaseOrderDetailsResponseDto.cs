using LeadingEdgeServer.Models.Entity.Inventory.ItemUnit;
using LeadingEdgeServer.Models.Entity.Inventory;
using LeadingEdgeServer.Models.Entity.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Purchase
{
    public record PurchaseOrderDetailsResponseDto
    {
        public Guid Id { get; set; }
        public Guid? ItemRequisitionMasterId { get; set; }
        public Guid PurchaseOrderId { get; set; }
        public Guid ItemId { get; set; }
        public Guid? ProductId { get; set; }
        public Guid UnitId { get; set; }
        public string UnitName { get; set; }
        public string ItemNameChain { get; set; }
        public string ItemName { get; set; }
        public double CurrencyAmount { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? ModelNo { get; set; }
        public string? skuNo { get; set; }
        public string? StyleNo { get; set; }
        public Nullable<Guid> BrandId { get; set; }
        public Guid? CategoryId { get; set; }
        public double? AlertQty { get; set; }
        public string? Weight { get; set; }  
        public double? IrQuantity { get; set; }
        public double? Remaining { get; set; }
    }
}
