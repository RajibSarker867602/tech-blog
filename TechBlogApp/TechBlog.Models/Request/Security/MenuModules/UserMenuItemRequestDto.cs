using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.MenuModules
{
    public class UserMenuItemRequestDto
    {
        public Nullable<Guid> UserId { get; set; }
        public Nullable<Guid> GroupId { get; set; }
        public List<Guid> Menus { get; set; }
    }
}
