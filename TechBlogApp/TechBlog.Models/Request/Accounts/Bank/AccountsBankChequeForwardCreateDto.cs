using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.Bank
{
    public class AccountsBankChequeForwardCreateDto
    {
        // public Guid Id { get; set; }
        [Required(ErrorMessage = "Bank cheque is required")]
        public Guid BankChequeId { get; set; }
        [Required(ErrorMessage = "Amount is required")]
        public double Amount { get; set; }
        [Required(ErrorMessage = "COA is required")]
        public Guid CrCOAId { get; set; }
        [Required(ErrorMessage = "Control A/C is required")]
        public Guid DrCOAId { get; set; }
        public Guid? SupplierCustomerId { get; set; }
        [Required(ErrorMessage = "Issue date is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Issue date should be date time only")]
        public DateTime IssueDate { get; set; }
        public string? PayTo { get; set; }
        [Required(ErrorMessage = "Cheque issue purpose is required")]
        public string ChequeIssuePurpose { get; set; }
        [Required(ErrorMessage = "Place date is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Place date should be date time only")]
        public DateTime? PlaceDate { get; set; }
        [Required(ErrorMessage = "Delivered status is required")]
        public bool IsDelivered { get; set; }
        [Required(ErrorMessage = "Narration is required")]
        public string? Narration { get; set; }
        public Guid? CurrencyId { get; set; }
        public Double? ConvertionRate { get; set; }
    }
}
