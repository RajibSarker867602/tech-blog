using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public class AccountsProjectCOAMasterRequestDto
    {
        public List<Guid> Ids { get; set; }
        public Guid? ProjectId { get; set; }
    }
}
