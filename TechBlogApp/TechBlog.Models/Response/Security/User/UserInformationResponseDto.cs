using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.User
{
    public class UserInformationResponseDto
    {
        public int SL { get; set; }
        public Guid UserId { get; set; }
        public Guid ParentId { get; set; }
        public string UserName { get; set; }
        public string UserGroupName { get; set; }
        public string Email { get; set; }
        public string EmployeeId { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdminUser { get; set; }
    }
}
