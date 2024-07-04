using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory
{
    public class InvCategoryCreateDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }
        public Nullable<Guid> ParentId { get; set; }
        [Required(ErrorMessage = "Project is required")]
        public Guid ProjectId { get; set; }
        [Required(ErrorMessage = "Type is required")]
        public int Type { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
    }
}
