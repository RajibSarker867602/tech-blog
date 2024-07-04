using LeadingEdgeServer.Models.Entity.Accounts.OpeningBalance;
using LeadingEdgeServer.Models.Entity.Accounts;
using LeadingEdgeServer.Models.Entity.Common;
using LeadingEdgeServer.Models.Entity.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.OpeningBalance
{
    public class SupplierCustomerOpeningBalanceCreateDto
    {
        public Guid Id { get; set; }
        public Guid? OpeningBalanceMasterId { get; set; }
        public Guid? ProjectId { get; set; }
        public string? Narration { get; set; }
        public double? DrAmount { get; set; }
        public double? CrAmount { get; set; }
    }
}
