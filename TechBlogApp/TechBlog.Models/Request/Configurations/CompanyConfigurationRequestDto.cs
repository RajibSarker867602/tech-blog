using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Configurations
{
    public class CompanyConfigurationRequestDto
    {
        public Guid CompanyId { get; set; }
        public string Configurations { get; set; }
    }
}
