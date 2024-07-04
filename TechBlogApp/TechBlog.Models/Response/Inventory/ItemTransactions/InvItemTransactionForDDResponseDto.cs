using LeadingEdgeServer.Models.Common;
using LeadingEdgeServer.Models.Enum.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Inventory.ItemTransactions
{
    public class InvItemTransactionForDDResponseDto
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string TransactionCode { get; set; }
        public Guid? TransactionId { get; set; }
        public InvFeatureEnum TransactionType { get; set; }
        public string TransactionTypeName => this.TransactionType.GetEnumTitle(true);
    }
}
