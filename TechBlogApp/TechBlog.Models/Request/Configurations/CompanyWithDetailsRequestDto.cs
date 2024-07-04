using LeadingEdgeServer.Models.Request.Common;
using LeadingEdgeServer.Models.Request.MenuModules;
using LeadingEdgeServer.Models.Request.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Configurations
{
    public class CompanyWithDetailsRequestDto
    {
        public CompanyWithDetailsRequestDto()
        {
            Projects = new List<ProjectRequestDto>();
        }
        public CompanyRequestDto Company { get; set; }
        public ICollection<ProjectRequestDto> Projects { get; set; }
        public UserGroupRequestDto UserGroup { get; set; }
        public UserInformationRequestDto User { get; set; }
        public UserMenuPermissionRequestParams UserPermission { get; set; }
    }
}
