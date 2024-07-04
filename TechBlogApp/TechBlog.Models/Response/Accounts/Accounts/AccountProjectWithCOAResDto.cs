using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.Accounts
{
    public class AccountProjectWithCOAResDto
    {
        public AccountProjectWithCOAResDto()
        {
            AccountsCOAMasters = new List<AccountsCOAMastersResDto>();
        }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public ICollection<AccountsCOAMastersResDto> AccountsCOAMasters { get; set; }
    }

    public class AccountsCOAMastersResDto
    {
        public Guid Id { get; set; }
        public string COAName { get; set; }
        public string? COANumber { get; set; }
        public string? COADisplayNumber { get; set; }
        public bool isItemChecked { get; set; } = false;
    }
}
