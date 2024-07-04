using LeadingEdgeServer.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public class AccountsCoaQueryDto
    {
        public Guid? Id { get; set; }
        public string? Direction { get; set; } = "ASC";
        public Guid? ProjectId
        {
            get
            {
                return CurrentUserServiceData.ProjectId;
            }
            set { }
        }
        public bool? IsActive { get; set; }
    }
}
