using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Views
{
    public class VWUserCompanyWithProject
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Nullable<Guid> UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public string Configurations { get; set; }
    }
}
