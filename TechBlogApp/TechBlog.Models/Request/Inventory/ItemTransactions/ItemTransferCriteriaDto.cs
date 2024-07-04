using LeadingEdgeServer.Models.Enum.Inventory;
using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory.ItemTransactions
{
    public class ItemTransferCriteriaDto : PageParams
    {
        public Guid? Id { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set;}
        public string? Code { get; set; }
        public string? Status { get; set; }
        public InvFeatureEnum? TransactionType { get; set; }
    }
}
