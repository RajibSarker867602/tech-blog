using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory.ItemUnit
{
    public class InventoryItemUnitConversionRequestDto
    {
        public Guid? ParentId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public double Conversion { get; set; }
        public Guid? ProjectId { get; set; }
        public bool IsActive { get => _isActive; set { _isActive = value; } }
        private bool _isActive = true;
    }
}
