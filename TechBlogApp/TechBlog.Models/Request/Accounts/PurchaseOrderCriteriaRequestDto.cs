using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public class PurchaseOrderCriteriaRequestDto : PageParams
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? StoreId { get; set; }
        public Guid? Id { get; set; }
        public string? Code { get; set; }
        public int? Status { get; set; }
    }
}
