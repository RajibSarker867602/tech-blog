using LeadingEdgeServer.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Security.ApprovalLogs
{
    public record SecurityApprovalLogsRequestDto
    {
        public Guid? Id { get; set; }
        public ApprovalTypeEnum StatusId { get; set; }
    }
}
