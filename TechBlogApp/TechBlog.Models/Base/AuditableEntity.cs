namespace TechBlog.Models.Base
{
    public class AuditableEntity
    {
        public string? AutoGenCode { get; set; }
        public bool IsDeleted { get; set; }
        public Guid CreatedById { get; set; }

        //public UserInformation CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public Nullable<Guid> LastModifiedById { get; set; }

        //public UserInformation LastModifiedBy { get; set; }
        public Nullable<DateTime> LastModifiedOn { get; set; }
    }
}