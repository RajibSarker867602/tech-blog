using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.UserConnections
{
    public class UserConnectionUpdateRequstDto
    {
        public string ConnectionId { get; set; }
        public bool IsActive { get; set; }
    }
}
