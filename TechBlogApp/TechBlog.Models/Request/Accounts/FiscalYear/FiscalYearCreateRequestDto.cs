using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.FiscalYear
{
    public class FiscalYearCreateRequestDto
    {
        public Guid ProjectId { get; set; }
        public string FascialYearName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public double IncomeTaxPercentage { get; set; }
    }
}
