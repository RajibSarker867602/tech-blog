using LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Inventory.ItemTransactions
{
    public record InventoryTransactionWrapperResponseDto
    {
        public InventoryTransactionWrapperResponseDto()
        {
            InvItemTransactionList = new List<SP_GetInventoryTransactionByCriteria>();
        }
        public int RecordCount { get; set; }
        public ICollection<SP_GetInventoryTransactionByCriteria> InvItemTransactionList { get; set; }
    }
}
