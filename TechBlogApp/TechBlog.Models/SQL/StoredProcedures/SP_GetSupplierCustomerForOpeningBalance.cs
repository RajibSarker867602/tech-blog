using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures
{
    public record SP_GetSupplierCustomerForOpeningBalance
    {
        public Guid Id { get; set; }
        public Guid? TransectionId { get; set; }
        public Guid? OpeningBalanceMasterId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid ProjectId { get; set; }
        public double? CrAmount { get; set; }
        public double? DrAmount { get; set; }
        public string TypeName { get; set; }
        public bool IsReadOnly { get; set; }
        public int type { get; set; }
        public Guid? FiscalYearId { get; set; }
        public DateTime? OpeningBalanceDate { get; set; }
    }
}
