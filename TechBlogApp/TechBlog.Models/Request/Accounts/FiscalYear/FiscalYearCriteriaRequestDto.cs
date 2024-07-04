using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.FiscalYear
{
    public class FiscalYearCriteriaRequestDto : PageParams
    {
        public Guid? ProjectId { get; set; }
    }
}
