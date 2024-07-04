using LeadingEdgeServer.Models.SQL.StoredProcedures;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.Accounts
{
    public class AccountsCoaResponseDto
    {
        public AccountsCoaResponseDto()
        {
            Childrens = new List<AccountsCoaResponseDto>();
        }
        public Guid? Id { get; set; }
        public Guid? ParentId { get; set; }
        public AccountsCoaResponseDto Parent { get; set; }
        public Guid? ProjectId { get; set; }
        public string COANumber { get; set; }
        public string COADisplayNumber { get; set; }
        public string COAName { get; set; }
        public int COALevel { get; set; }
        public string Hierarchy { get; set; }
        //public string HierarchyIndex { get; set; }
        public bool IsActive { get; set; }
        public string? COAType { get; set; }
        public bool IsTransactionalHead { get; set; }
        public bool IsEnabled { get; set; } = false;
        public Guid CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid? LastModifiedById { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public ICollection<AccountsCoaResponseDto>? Childrens { get; set; }
    }
}
