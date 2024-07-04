using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.Bank
{
    public class AccountBankChequeForwardInactive
    {
        public Guid Id { get; set; }
        public bool IsInactive { get; set; }
        public string? Narration { get; set; }
    }
}
