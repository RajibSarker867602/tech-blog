using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory
{
    public class SupplierCustomerCriteriaRequestDto : PageParams
    {
        public SupplierCustomerCriteriaRequestDto()
        {
            TypeIds = new List<int>();
        }

        public Guid? ProjectId { get; set; }
        public Guid? coaId { get; set; }
        public ICollection<int>? TypeIds { get; set; }
    }
}
