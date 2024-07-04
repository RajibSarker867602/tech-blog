using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public class AccountCOAUpdateRequestDto
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        //public Guid? ProjectId { get; set; }
        public string COANumber { get; set; }
        public string COAName { get; set; }
        //public int COALevel { get; set; }
        //public string Hierarchy { get; set; }
        //public string HierarchyIndex { get; set; }
        public bool IsActive { get; set; }
        public string? coaType { get; set; }
        public bool IsTransactionalHead { get; set; }
        public bool IsBaseCOA { get; set; } = false;
    }
}
