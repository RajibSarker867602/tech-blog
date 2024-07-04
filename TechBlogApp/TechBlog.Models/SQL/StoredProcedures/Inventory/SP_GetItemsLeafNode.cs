using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory
{
    public record SP_GetItemsLeafNode
    {
        public Guid? Id { get; set; }
        public Guid ItemId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid ParentId { get; set; }
        public string Name { get; set; }
        public string StyleNo { get; set; }
        public string ModelNo { get; set; }
        public string SKUNo { get; set; }
        public Guid UnitId { get; set; }
        public string UnitName { get; set; }
        public Guid BrandId { get; set; }
        public string FullName { get; set; }
        public int Level { get; set; }
        public Guid? StoreId { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Total { get; set; }
        public bool IsReadOnly { get; set; }
    }
}
