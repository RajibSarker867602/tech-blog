using LeadingEdgeServer.Models.Enum;
using LeadingEdgeServer.Models.Enum.Inventory;
using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory.ItemTransactions
{
    public class InventoryTransactionCriteriaDto : PageParams
    {
        public Guid? Id { get; set; }
        public Guid? ProjectId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? StoreId { get; set; }
        public string? TransactionCode { get; set; }
        public string? PurchaseOrder { get; set; }
        public ApprovalTypeEnum? Status { get; set; }
        public InvFeatureEnum? TransactionType { get; set; }
    }
}
