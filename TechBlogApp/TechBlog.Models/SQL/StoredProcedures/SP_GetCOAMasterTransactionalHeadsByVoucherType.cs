using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures
{
    [Keyless]
    public class SP_GetCOAMasterTransactionalHeadsByVoucherType
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? ProjectId { get; set; }
        public string COAName { get; set; }
        public string COANumber { get; set; }
        public int COALevel { get; set; }
        public string? Hierarchy { get; set; }
        public string? COAType { get; set; }
    }
}
