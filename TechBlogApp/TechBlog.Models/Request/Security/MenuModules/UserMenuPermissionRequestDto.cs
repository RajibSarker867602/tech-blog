using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.MenuModules
{
    public class UserMenuPermissionRequestDto
    {
        //public Guid ProjectId { get; set; }
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
        public Nullable<Guid> CreatedById { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }

    public class UserMenuPermissionRequestParams
    {
        public UserMenuPermissionRequestParams()
        {
            Permissions = new List<UserMenuPermissionRequestDto>();
        }
        public Guid UserId { get; set; }
        public ICollection<UserMenuPermissionRequestDto> Permissions { get; set; }
    }

    public class ApprovedPermissionsRequestDto
    {
        public Guid Id { get; set; }
        public bool IsUser { get; set; }
    }
}
