using LeadingEdgeServer.Models.Common;
using LeadingEdgeServer.Models.Enum;
using LeadingEdgeServer.Models.Enum.AutoVoucher;
using LeadingEdgeServer.Models.Enum.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Inventory.ItemTransactions
{
    public record InventoryTransactionAutoVoucherMasterResponseDto
    {
        public InventoryTransactionAutoVoucherMasterResponseDto()
        {
            TransactionDetails = new List<InventoryTransactionAutoVoucherDetailsResponseDto>();
        }
        public Guid Id { get; set; }
        public Guid MasterId { get; set; }
        public Guid FiscalYearId { get; set; }
        public bool IsFiscalyearClosed { get; set; }
        public string Remarks { get; set; }
        public ApprovalTypeEnum StatusId { get; set; }
        public string AutoGenCode { get; set; }
        public Guid SupplierId { get; set; }
        public double DiscountPercentage { get; set; }
        public double SpecialDiscount { get; set; }
        public double VatPercentage { get; set; }
        public double AdditionalCharge { get; set; }
        public double ConvertionRate { get; set; }
        public Guid CurrencyId { get; set; }
        public DateTime TransactionDate { get; set; }
        public double ItemTotalDiscount { get; set; }
        public double ItemTotalSalePrice { get; set; }
        public double ItemTotalCostPrice { get; set; }
        public double ItemTotalDiscountedPrice { get; set; }
        public double TotalDiscountPercentageAmount { get; set; }
        public double TotalItemPriceAfterPercentageDiscount { get; set; }
        public double TotalItemPriceAfterAllDiscount { get; set; }
        public double TotalVatAmount { get; set; }
        public double TotalAmountWithVat { get; set; }
        public double TotalGrandAmount { get; set; }
        public double TotalLocalPrice { get; set; }
        public PaymentModeEnum PaymentMode { get; set; }
        public TransactionModeEnum TransactionMode { get; set; }
        public InvFeatureEnum TransactionType { get; set; }
        public ICollection<InventoryTransactionAutoVoucherDetailsResponseDto> TransactionDetails { get; set; }
    }

    public record InventoryTransactionAutoVoucherDetailsResponseDto
    {
        public Guid Id { get; set; }
        public Guid TransactionMasterId { get; set; }
        public Guid ItemId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid ProductId { get; set; }
        public Guid UnitId { get; set; }
        public double Quantity { get; set; }
        public double ActualQuantity { get; set; }
        public double UnitPrice { get; set; }
        public double ItemPurchasePrice { get; set; }
        public double ItemSalePrice { get; set; }
        public double ItemDiscount { get; set; }
        public double ItemDiscountPrice { get; set; }
        public double ItemTotalDiscountPrice { get; set; }
        public Guid RootCategoryId { get; set; }
    }
}
