using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.User
{
    public class UserInformationRequestDto
    {
        public Nullable<Guid> Id { get; set; } = Guid.Empty;
        public Nullable<Guid> ParentId { get; set; } = Guid.Empty;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string EmployeeId { get; set; }
        public bool IsAdminUser { get; set; }
    }
}
