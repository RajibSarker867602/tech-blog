using LeadingEdgeServer.Models.Response.Accounts.VoucherEntry;
using LeadingEdgeServer.Models.SQL.StoredProcedures.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Purchase
{
    public record PurchaseOrderListResponseDto
    {
        public PurchaseOrderListResponseDto()
        {
            PurchaseOrderList = new List<SP_GetPurchaseOrdersByCriteria>();
        }
        public int RecordCount { get; set; }
        public ICollection<SP_GetPurchaseOrdersByCriteria> PurchaseOrderList { get; set; }
    }
}
