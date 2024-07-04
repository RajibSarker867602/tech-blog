using LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory;
using LeadingEdgeServer.Models.SQL.StoredProcedures.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Inventory.ItemTransactions
{
    public record InvItemTransferResponseDto
    {
        public InvItemTransferResponseDto()
        {
            ItemTransferList = new List<SP_GetInvItemTransferListByCriteria>();
        }
        public int RecordCount { get; set; }
        public ICollection<SP_GetInvItemTransferListByCriteria> ItemTransferList { get; set; }
    }
}
