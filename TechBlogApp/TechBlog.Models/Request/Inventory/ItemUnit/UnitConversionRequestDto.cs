using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory.ItemUnit
{
    public record UnitConversionRequestDto
    {
        public Guid FromUnitId { get; set; }
        public Guid ToUnitId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}