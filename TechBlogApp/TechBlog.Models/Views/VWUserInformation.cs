using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Views
{
    public class VWUserInformation
    {
        public Guid UserId { get; set; }
        public Guid ParentId { get; set; }
        public Guid ProjectId { get; set; }
        public string UserName { get; set; }
        public string UserGroupName { get; set; }
        public string Email { get; set; }
        public string EmployeeId { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdminUser { get; set; }
    }
}
