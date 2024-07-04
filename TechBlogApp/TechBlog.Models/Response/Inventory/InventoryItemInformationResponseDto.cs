using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Inventory
{
    public class InventoryItemInformationResponseDto
    {
        public InventoryItemInformationResponseDto()
        {
            ItemVariations = new List<InventoryItemInformationResponseDto>();
        }

        public int SL { get; set; }
        public Guid Id { get; set; }
        public string? AutoGenCode { get; set; }
        public Guid FiscalYearId { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Nullable<Guid> CategoryId { get; set; } = Guid.Empty;
        public string CategoryName { get; set; }
        public Nullable<Guid> ParentId { get; set; } = Guid.Empty;
        public string ParentItem { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string? StyleNo { get; set; }
        public string? ModelNo { get; set; }
        public string? SKUNo { get; set; }
        public string? BarCode { get; set; }
        public Guid? StoreId { get; set; }
        public Nullable<Guid> BrandId { get; set; }
        public string BrandName { get; set; }
        public Nullable<Guid> BaseUnitId { get; set; }
        public Nullable<Guid> UnitId { get; set; }
        public string UnitName { get; set; }
        public int AlertQty { get; set; }
        public string? ProductBrochureUrl { get; set; }
        public string? ImageUrl { get; set; }
        public int Weight { get; set; }
        public int VATId { get; set; }
        public int SellingPriceVATTypeId { get; set; }
        public int VariationTypeId { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsSellable { get; set; }
        public Guid? VariationId { get; set; }
        public string? VariationName { get; set; }
        public float Quantity { get; set; }
        public Guid BaseCurrencyId { get; set; }
        public double UnitPrice { get; set; }
        public double MRP { get; set; }
        public ICollection<InventoryItemInformationResponseDto> ItemVariations { get; set; }
    }
}
