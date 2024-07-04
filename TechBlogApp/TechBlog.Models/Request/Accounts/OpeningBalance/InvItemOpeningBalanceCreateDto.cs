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
    public class InvItemOpeningBalanceCreateDto
    {
        public Guid? Id { get; set; }
        public Guid ItemId { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid UnitId { get; set; }
        public Guid? BrandId { get; set; }
        public string? BarCode { get; set; }
        public Guid? StoreId { get; set; }
        public Guid? FiscalYearId { get; set; }
        public DateTime TransactionDate { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
    }
}
