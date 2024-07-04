using LeadingEdgeServer.Models.Entity.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBlog.Models.Base.Contracts;

namespace TechBlog.Models.Base
{
    public class AuditableEntity: IAuditableEntity
    {
        public string? AutoGenCode { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedById { get; set; }
        public UserInformation CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Nullable<Guid> LastModifiedById { get; set; }
        public UserInformation LastModifiedBy { get; set; }
        public Nullable<DateTime> LastModifiedOn { get; set; }
    }
}
