using LeadingEdgeServer.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.UserConnections
{
    public class UserConnectionRequestDto 
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string ConnectionId { get; set; }
        public bool IsActive { get; set; }
        public string DeviceInfo { get; set; }
    }
}
