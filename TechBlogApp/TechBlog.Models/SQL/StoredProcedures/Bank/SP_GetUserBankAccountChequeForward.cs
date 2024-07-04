
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Bank
{
    public class SP_GetUserBankAccountChequeForward
    {
        public Guid Id { get; set; }
        public Guid BankChequeId { get; set; }        
        public Guid CrCOAId { get; set; }
        public string? COAName { get; set; }
        public Guid DrCOAId { get; set; }
        public string? ControlLedger { get; set; }
        public string? DrCOAType { get; set; }
        public Guid? SupplierCustomerId { get; set; }
        public string? SupplierCustomerName { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? PlaceDate { get; set; }
        public string? PayTo { get; set; }
        public double Amount { get; set; }
        public string ChequeIssuePurpose { get; set; }
        public string? Narration { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsInactive { get; set; }
        public bool IsClean { get; set; }        
        public string SerialNumber { get; set; }
        public Guid BankId { get; set; }
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? CurrencyId { get; set; }
        public Double? ConvertionRate { get; set; }
    }
}
