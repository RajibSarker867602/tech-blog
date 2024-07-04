using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures
{
    public class SP_GetCOAMasterData
    {
        public SP_GetCOAMasterData()
        {
            Childrens = new List<SP_GetCOAMasterData>();
        }
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? ProjectId { get; set; }
        public string? COANumber { get; set; }
        public string? COADisplayNumber { get; set; }
        public string COAName { get; set; }
        public int COALevel { get; set; }
        public string? Hierarchy { get; set; }
        public bool IsActive { get; set; }
        public string? COAType { get; set; }
        public bool IsTransactionalHead { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid? LastModifiedById { get; set; }
        public DateTime? LastModifiedOn { get; set;}

        [NotMapped]
        public ICollection<SP_GetCOAMasterData> Childrens { get; set; }
    }
}
