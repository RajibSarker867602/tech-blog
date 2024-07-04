using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Inventory
{
    public class InvCategoryReturnDto
    {
        public InvCategoryReturnDto()
        {
            Items = new List<InventoryItemInformationResponseDto>();
        }
        public int SL { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<Guid> ParentId { get; set; }
        public string? ParentName { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectProjectName { get; set; }
        public int Type { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }    
        public string? FullName { get; set; }
        public Guid? Root { get; set; }
        public int? Level { get; set; }
        public ICollection<InventoryItemInformationResponseDto> Items { get; set; }
    }
}
