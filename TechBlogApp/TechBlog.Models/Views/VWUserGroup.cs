using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Views
{
    public class VWUserGroup
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public Guid GroupId { get; set; }
        public string UserGroup { get; set; }
        public bool IsGroupActive { get; set; }
    }
}
