using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures
{
    public class SP_GetUserProjectCOAMasters
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string? COANumber { get; set; }
        public string? COADisplayNumber { get; set; }
        public string COAName { get; set; }
        public int COALevel { get; set; }
        public bool IsActive { get; set; }
        public string? COAType { get; set; }
        public bool IsTransactionalHead { get; set; }
        
    }
}
