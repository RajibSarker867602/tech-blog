using LeadingEdgeServer.Models.Entity.Accounts.OpeningBalance;
using LeadingEdgeServer.Models.Entity.Accounts;
using LeadingEdgeServer.Models.Entity.Common;
using LeadingEdgeServer.Models.Entity.Inventory.ItemUnit;
using LeadingEdgeServer.Models.Entity.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory;

namespace LeadingEdgeServer.Models.Response.Accounts.OpeningBalance
{
    public record InvItemOpeningBalanceResponseDto
    {
        public Guid? CurrencyId { get; set; }
        public double? ConvertionRate { get; set; }
        public DateTime? OpeningDate { get; set; }
        
        public ICollection<SP_GetItemsLeafNode> InvItems { get; set; }
    }
}
