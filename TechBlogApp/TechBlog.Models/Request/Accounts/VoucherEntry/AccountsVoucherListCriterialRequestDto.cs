using LeadingEdgeServer.Models.Enum;
using LeadingEdgeServer.Models.Helpers;
using LeadingEdgeServer.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.VoucherEntry
{
    public class AccountsVoucherListCriterialRequestDto : PageParams
    {
        public AccountsVoucherListCriterialRequestDto()
        {
            ProjectIds = new List<Guid>();
        }
        public ICollection<Guid>? ProjectIds { get; set; }

        public Guid? ProjectId => CurrentUserServiceData.ProjectId;
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? VoucherNo { get;set; }
        public string? VoucherType { get; set;}
        public string? VoucherStatus { get; set;}
        public string? ReferenceNo { get; set;}
        public Guid? ReferenceVoucherNo { get; set;}
        public string? Narration { get;set;}
        public Guid? DonorId { get; set; }
        public Guid? DepartmentId { get;set;}
        public ApprovalTypeEnum? Status { get; set;}
        public int? RecordCount { get; set;}
    }
}
