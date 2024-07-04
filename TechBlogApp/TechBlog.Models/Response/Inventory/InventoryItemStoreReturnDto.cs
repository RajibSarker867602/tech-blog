using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Inventory
{
    public class InventoryItemStoreReturnDto
    {
        public int SL { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
        public string? ParentName { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public Guid ProjectId { get; set; }
        public string? ProjectProjectName { get; set; }
        public string? FullName { get; set; }
        public Guid? Root { get; set; }
    }
}
