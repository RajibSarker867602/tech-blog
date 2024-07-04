using LeadingEdgeServer.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory
{
    public record SP_GetInvItemTransferListByCriteria
    {
        public int SL { get; set; }
        public Guid Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string AutoGenCode { get; set; }
        public ApprovalTypeEnum StatusId { get; set; }
        public Guid FromStoreId { get; set; }
        public string FromStore { get; set; }
        public Guid ToStoreId { get; set; }
        public string ToStore { get; set; }
        public string? Remarks { get; set; }
        public string? ReferenceNo { get; set; }
    }
}
