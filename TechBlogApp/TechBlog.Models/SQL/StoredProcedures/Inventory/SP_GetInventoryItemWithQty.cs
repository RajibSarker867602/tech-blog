using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory
{
    public record SP_GetInventoryItemWithQty
    {
        public Guid ProjectId { get; set; }
        public Guid FiscalYearId { get; set; }
        public Guid StoreId { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Guid ItemId { get; set; }
        public string ItemName { get; set; }
        public Guid BaseUnitId { get; set; }
        public Guid UnitId { get; set; }
        public string? StyleNo { get; set; }
        public string? ModelNo { get; set; }
        public string? SKUNo { get; set; }
        public string? BarCode { get; set; }
        public Guid VariationId { get; set; }
        public string VariationName { get; set; }
        public float Quantity { get; set; }
        public Guid BaseCurrencyId { get; set; }
        public double UnitPrice { get; set; }
        public double MRP { get; set; }
    }
}
