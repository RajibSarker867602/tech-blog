using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory
{
    public class SP_GetInventoryItemUnites
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public double Conversion { get; set; }
        public bool IsActive { get; set; }
        public Guid? ProjectId { get; set; }
        public string? ParentName { get; set; }
        public string FullName { get; set; }
        public Guid Root { get; set; }
        public int Level { get; set; }
    }
}
