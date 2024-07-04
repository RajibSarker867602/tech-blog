using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Bank
{
    public class GetUserBankAccountCheque_SP
    {
        public Guid Id { get; set; }
        public string SerialNumber { get; set; }
        public Guid? VoucherMasterId { get; set; }
        public string VoucherNo { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; }
        public Guid BankId { get; set; }
        public string BankName { get; set; }
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public string BranchName { get; set; }
        public DateTime? IssueDate { get; set; }
        public string? VoucherNarration { get; set; }
    }
}
