using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory
{
    public class InventoryItemBrandCreateDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile? Image { get; set; }
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Project is required")]
        public Guid ProjectId { get; set; }
    }
}
