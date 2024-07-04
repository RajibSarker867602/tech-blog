using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.MenuModules
{
    public class UserPermissionResponseDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid MenuModuleId { get; set; }
        public string TransactionType { get; set; }
        public bool CanCreate { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanView { get; set; }
        public bool CanCheck { get; set; }
        public bool CanApprove { get; set; }
        public bool CanReject { get; set; }
    }
}
