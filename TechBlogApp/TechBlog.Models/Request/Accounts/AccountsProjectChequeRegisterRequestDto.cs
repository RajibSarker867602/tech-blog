using LeadingEdgeServer.Models.Entity.Accounts;
using LeadingEdgeServer.Models.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public class AccountsProjectChequeRegisterRequestDto
    {
        [Required(ErrorMessage = "Start number is required")]
        public int StartNumber { get; set; }
        [Required(ErrorMessage = "End number is required")]
        public int EndNumber { get; set; }
        public string? Prefix { get; set; }
        [Required(ErrorMessage = "Active status is required")]
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage = "Bank account is required")]
        public Guid AccountsBankId { get; set; }
        [Required(ErrorMessage = "Issue date is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Issue date should be date time only")]
        public DateTime IssueDate { get; set; }
    }
}
