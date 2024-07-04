using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.Bank
{
    public class AccountsCOABankRequestDto
    {
        public Guid AccountsBankId { get; set; }
        public Guid AccountsCOAMasterId { get; set; }
    }
}
