using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.CommonCompanies
{
    public class CompanyWithProjectResponseDto
    {
        public CompanyWithProjectResponseDto()
        {
            UserCompaniesWithProjects = new List<ComapanyWithProjectContainer>();
        }
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public ICollection<ComapanyWithProjectContainer> UserCompaniesWithProjects { get; set; }
    }

    public class ComapanyWithProjectContainer
    {
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
