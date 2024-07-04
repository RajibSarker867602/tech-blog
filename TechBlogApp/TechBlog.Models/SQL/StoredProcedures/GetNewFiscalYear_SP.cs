using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures
{
    public record GetNewFiscalYear_SP
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FascialYearName { get; set; }
    }
}
