using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.Bank
{
    public class BankChequeCriteriaDto: PageParams
    {
        public Guid? BankId { get; set; }
        public bool? IsActive { get; set; }
        public Guid? COAId { get; set; }
    }
}
