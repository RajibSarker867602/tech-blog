using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory
{
    public class SP_GetInvCategories
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public Guid? ParentId { get; set; }
        public string? Description { get; set; }
        public string? FullName { get; set; }
        public Guid Root { get; set; }
        public int Level { get; set; }
        public bool IsActive { get; set; }
    }
}
