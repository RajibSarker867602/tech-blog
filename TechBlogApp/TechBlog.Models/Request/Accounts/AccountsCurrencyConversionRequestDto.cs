using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public class AccountsCurrencyConversionRequestDto
    {
        public Guid ProjectId { get; set; }
        public Guid FromCurrencyId { get; set; }
    }
}
