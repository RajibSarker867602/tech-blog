using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.Bank
{
    public class AccountsBanksCriteriaDto: PageParams
    {
        //public string? SearchKey { get; set; }
        //public string AccountNo { get; set; }
        //public string BranchName { get; set; }
        //public string? BankName { get; set; }
        public Guid? COAId { get; set; }
    }
}
