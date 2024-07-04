using LeadingEdgeServer.Models.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Payroll
{
    public class PayrollDepartmentRequestDto
    {
        public string Name { get; set; }
        public Guid ProjectId { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
    }
}
