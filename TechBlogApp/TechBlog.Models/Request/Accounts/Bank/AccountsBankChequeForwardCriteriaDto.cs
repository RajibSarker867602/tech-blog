using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.Bank
{
    public class AccountsBankChequeForwardCriteriaDto: PageParams
    {
        public Guid? Id { get; set; }
    }
}
