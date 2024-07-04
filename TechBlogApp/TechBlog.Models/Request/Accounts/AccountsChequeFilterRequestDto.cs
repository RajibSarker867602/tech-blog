using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public class AccountsChequeFilterRequestDto
    {
        public Guid? BankId { get; set; }
        public Guid? coaId { get; set; }
    }
}
