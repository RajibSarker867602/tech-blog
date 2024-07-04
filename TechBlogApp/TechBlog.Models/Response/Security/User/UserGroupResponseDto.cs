using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.User
{
    public class UserGroupResponseDto
    {
        public UserGroupResponseDto()
        {
            UserGroupProjectIds = new List<Guid>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Guid> UserGroupProjectIds { get; set; }
    }
}
