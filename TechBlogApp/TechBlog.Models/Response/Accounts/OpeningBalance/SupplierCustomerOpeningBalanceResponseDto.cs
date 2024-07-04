using LeadingEdgeServer.Models.SQL.StoredProcedures;
using LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.OpeningBalance
{
    public record SupplierCustomerOpeningBalanceResponseDto
    {
        public Guid? CurrencyId { get; set; }
        public double? ConvertionRate { get; set; }
        public DateTime? OpeningDate { get; set; }

        public ICollection<SP_GetSupplierCustomerForOpeningBalance> SupplierCustomerBalances { get; set; }
    }
}
