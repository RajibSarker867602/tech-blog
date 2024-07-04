using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures
{
    [Keyless]
    public class SP_DeleteCOAMaster
    {
        public Guid COAId { get; set; }
    }
}
