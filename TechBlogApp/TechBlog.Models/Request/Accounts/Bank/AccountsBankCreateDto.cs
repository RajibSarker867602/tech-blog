using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.Bank
{
    public class AccountsBankCreateDto
    {
        //public Guid? Id { get; set; }
        [Required(ErrorMessage = "Account name is required")]
        public string AccountName { get; set; }
        [Required(ErrorMessage = "Account no is required")]
        public string AccountNo { get; set; }
        [Required(ErrorMessage = "Branch name is required")]
        public string BranchName { get; set; }
        [Required(ErrorMessage = "Bank name is required")]
        public string BankName { get; set; }
        [Required(ErrorMessage = "Cheque size is required")]
        public string ChequeSize { get; set; }
        [Required(ErrorMessage = "Account type is required")]
        public string AccountType { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Routing is required")]
        public string Routing { get; set; }
        public ICollection<Guid> COAIds { get; set; }
    }
}
