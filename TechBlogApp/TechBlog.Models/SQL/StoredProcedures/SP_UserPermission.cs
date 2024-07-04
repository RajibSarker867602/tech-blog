using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures
{
    [Keyless]
    public class SP_UserPermission
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public Guid ModuleId { get; set; }
        public string ModuleName { get; set; }
        public Guid MenuId { get; set; }
        public string MenuName { get; set; }
        public int MenuLevel { get; set; }
        public Guid MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public int MenuItemLevel { get; set; }
        public bool CanCreate { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
    }
}
