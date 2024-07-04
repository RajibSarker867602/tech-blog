using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory
{
    public record SP_GetUnitesByItem
    {
        public Guid Id { get; init; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public double Conversion { get; set; }
        public bool IsActive { get; set; }
        public string FullName { get; set; }
        public int Level { get; set; }
    }



}
