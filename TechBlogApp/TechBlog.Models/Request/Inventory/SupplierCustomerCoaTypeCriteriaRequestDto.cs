using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory
{
    public class SupplierCustomerCoaTypeCriteriaRequestDto
    {
        public string? Name { get; set; }
        public string? CoaType { get; set; }
        public Guid ProjectId { get; set; }
    }
}
