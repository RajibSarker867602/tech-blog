using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory
{
    public class InventoryItemBrandCriteriaDto : PageParams
    {
        public string? Name { get; set; }
    }
}
