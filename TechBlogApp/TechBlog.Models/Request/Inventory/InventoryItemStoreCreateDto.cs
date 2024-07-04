using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory
{
    public class InventoryItemStoreCreateDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public Guid? ParentId { get; set; } = Guid.Empty;
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage = "Project is required")]
        public Guid ProjectId { get; set; }
    }
}
