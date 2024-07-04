using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory
{
    public class InventoryItemInformationRequestDto
    {
        public InventoryItemInformationRequestDto()
        {
            ItemVariations = new List<InventoryItemInformationRequestDto>();
        }

        public Nullable<Guid> Id { get; set; }
        public string? AutoGenCode { get; set; }
        [Required(ErrorMessage = "Project is required.")]
        public Guid ProjectId { get; set; }
        //[Required(ErrorMessage = "Category is required.")]
        public Nullable<Guid> CategoryId { get; set; }
        public Nullable<Guid> ParentId { get; set; }
        [Required(ErrorMessage = "Item name is required.")]
        public string Name { get; set; }
        public string? StyleNo { get; set; }
        public string? ModelNo { get; set; }
        public string? SKUNo { get; set; }
        public Nullable<Guid> BrandId { get; set; }
        //[Required(ErrorMessage = "Unit is required.")]
        public Nullable<Guid> UnitId { get; set; }
        public int AlertQty { get; set; }
        public IFormFile? ProductBrochureFile { get; set; }
        public string? ProductBrochureUrl { get; set; }
        public IFormFile? ImageFile { get; set; }
        public string? ImageUrl { get; set; }
        public double Weight { get; set; }
        public int VATId { get; set; }
        public double VATPercentage { get; set; }
        public int SellingPriceVATTypeId { get; set; }
        public double SellVATPercentage { get; set; }
        public int VariationTypeId { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsSellable { get; set; }
        public ICollection<InventoryItemInformationRequestDto>? ItemVariations { get; set; }
    }
}
