using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Inventory
{
    public class InveItemsWithCategory
    {
        public InveItemsWithCategory()
        {
            Categories = new List<InvCategoryReturnDto>();
            Items = new List<InventoryItemInformationResponseDto>();
        }
        public ICollection<InvCategoryReturnDto> Categories { get; set; }
        public ICollection<InventoryItemInformationResponseDto> Items { get; set; }
    }
}
