using LeadingEdgeServer.Models.Enum.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory
{
    public record SP_SalesDetailsByMaster
    {
        public Guid Id { get; set; }
        public Guid TransactionMasterId { get; set; }
        public Guid ProductId { get; set; }
        public Guid ItemId { get; set; }
        public Guid UnitId { get; set; }
        public Guid StoreId { get; set; }
        public string BarCode { get; set; }
        public int Quantity { get; set; }
        public int? AvailableQuantity { get; set; }
        public double UnitPrice { get; set; }
        public double SalePrice { get; set; }
        public DiscountTypeEnum DiscountById { get; set; }
        public double DiscountAmount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool IsActive { get; set; }
    }
}
