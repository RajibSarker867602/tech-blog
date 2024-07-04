using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.Bank
{
    public class AccountsCOABankResponseDto
    {
        public Guid Id { get; set; }
        public Guid AccountsBankId { get; set; }
        public Guid AccountsCOAMasterId { get; set; }
        public string AccountsCOAMasterCOAName { get; set; }

    }
}
