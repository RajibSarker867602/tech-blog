using LeadingEdgeServer.Models.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.FiscalYear
{
    public class AccountsFiscalYearResponseDto
    {
        public int SL { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string FascialYearName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public double IncomeTaxPercentage { get; set; }
        public bool IsFiscalyearClosed { get; set; }
    }
}
