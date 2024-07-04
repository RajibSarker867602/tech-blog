using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Security.User
{
    public class UserGroupForSearchDto
    {
        public Nullable<Guid> UserId { get; set; }
        public string? UserName { get; set; }
    }
}
