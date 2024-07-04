using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Common
{
    public class ProjectRequestDto
    {
        public Nullable<Guid> Id { get; set; }
        public Guid CompanyId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double BudgetAmount { get; set; }
        public bool IsDefaultProject { get; set; }
        public Nullable<Guid> CreatedById { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public Guid? LastModifiedById { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
