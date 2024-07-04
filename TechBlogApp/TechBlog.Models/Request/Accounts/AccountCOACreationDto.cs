using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public class AccountCOACreationDto
    {
        public Guid? ParentId { get; set; }
        //public Guid? ProjectId { get; set; }
        [Required(ErrorMessage = "COA Number is required")]
        public string COANumber { get; set; }
        [Required(ErrorMessage = "COA Name is required")]
        public string COAName { get; set; }
        [Required(ErrorMessage = "COA Level is required")]
        public int COALevel { get; set; }
        public string? coaType { get; set; }
        //public string Hierarchy { get; set; }
        //public string HierarchyIndex { get; set; }
        public bool IsActive { get; set; }
        //public string COAType { get; set; }
        //public bool IsTransactionalHead { get; set; }
    }
}
