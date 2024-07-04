using LeadingEdgeServer.Models.Entity.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBlog.Models.Base.Contracts
{
    public interface IAuditableEntity
    {
        public string? AutoGenCode { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedById { get; set; }
        public UserInformation CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid? LastModifiedById { get; set; }
        public UserInformation LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
    }
}
