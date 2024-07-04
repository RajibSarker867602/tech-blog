using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Inventory
{
    public class InventoryItemBrandReturnDto
    {
        public int SL { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string? ImageUrl { get; set; }
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectProjectName { get; set; }
    }
}
