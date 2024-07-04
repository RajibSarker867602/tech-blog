using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Views
{
    public class VWMenuModule
    {
        public VWMenuModule()
        {
            MenuModules = new List<VWMenuModule>();
        }
        public Guid MenuId { get; set; }
        public Nullable<Guid> ParentId { get; set; }
        public string Name { get; set; }
        public string ParentMenu { get; set; }
        public string Code { get; set; }
        public string Route { get; set; }
        public string DisplayName { get; set; }
        public int DisplaySequence { get; set; }
        public bool HasApprovalProcess { get; set; }
        public string PageType { get; set; }
        public string IconClass { get; set; }
        public int Level { get; set; }
        public ICollection<VWMenuModule> MenuModules { get; set; }
    }
}
