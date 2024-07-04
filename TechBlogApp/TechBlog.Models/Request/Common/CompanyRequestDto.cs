using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Common
{
    public class CompanyRequestDto
    {
        public Nullable<Guid> Id { get; set; }
        public Nullable<Guid> ParentId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string Configurations { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string WebUrl { get; set; }
        public string TIN { get; set; }
        public string BIN { get; set; }
        public Guid CompanyTypeId { get; set; }
        public Guid ThemeId { get; set; }
        public bool IsActive { get; set; }
    }
}
