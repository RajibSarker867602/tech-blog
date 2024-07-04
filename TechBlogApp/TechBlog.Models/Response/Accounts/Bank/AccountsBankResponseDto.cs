using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.Bank
{
    public class AccountsBankResponseDto
    {
        public int? SL { get; set; }
        public Guid Id { get; set; }
        public string DisplayBankName { get; set; }
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public string BranchName { get; set; }
        public string BankName { get; set; }
        public string ChequeSize { get; set; }
        public string AccountType { get; set; }
        public string Description { get; set; }
        public string Routing { get; set; }
        public ICollection<AccountsCOABankResponseDto>? AccountsCOABanks { get; set; }


    }
}
