using LeadingEdgeServer.Models.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.Inventory
{
    public class SupplierCustomerResponseDto
    {
        public int SL { get; set; }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? CompanyId { get; set; }
        public string ProjectName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? WebAddress { get; set; }
        //public double? Balance { get; set; }
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
        public int Type { get; set; }
    }
}
