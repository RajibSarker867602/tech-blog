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
    public class InvItemTransactionResponseDto
    {
        public InvItemTransactionResponseDto()
        {
            TransactionDetails = new List<InvItemTransactionDetailsResponseDto>();
        }
        public int SL { get; set; }
        public Guid Id { get; set; }
        public Guid FiscalYearId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? SupplierId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? AutoGenCode { get; set; }
        public Guid? TransactionId { get; set; }
        public InvFeatureEnum TransactionType { get; set; }
        public string TransactionTypeName => this.TransactionType.GetEnumTitle(true);
        public PaymentModeEnum PaymentMode { get; set; }
        public string PaymentModeName => this.PaymentMode.GetEnumTitle(true);
        public TransactionModeEnum TransactionMode { get; set; }
        public string TransactionModeName => this.TransactionMode.GetEnumTitle(true);
        public bool IsFiscalyearClosed { get; set; }
        public Guid? BankId { get; set; }
        public string? EXPNo { get; set; }
        public string? Shipped { get; set; }
        public string? HSCode { get; set; }
        public string? BillOfLaydingNo { get; set; }
        public string? ERCNo { get; set; }
        public string? MotherVesselNo { get; set; }
        public string? IRCNo { get; set; }
        public string? ContainerNo { get; set; }
        public string? EBinNo { get; set; }
        public string? SealNo { get; set; }
        public string? FeederVesselNo { get; set; }
        public double DiscountPercentage { get; set; }
        public double SpecialDiscount { get; set; }
        public double VatPercentage { get; set; }
        public double AdditionalCharge { get; set; }
        public string? ReferenceNo { get; set; }
        public string? FileUrl { get; set; }
        public bool IsActive { get; set; }
        public string? Remarks { get; set; }
        public Guid? CurrencyId { get; set; }
        public Double? ConvertionRate { get; set; }
        public ApprovalTypeEnum StatusId { get; set; }
        public string StatusName => this.StatusId.GetEnumTitle(true);
        public double GrandTotalAmount { get; set; }
        public ICollection<InvItemTransactionDetailsResponseDto> TransactionDetails { get; set; }
    }

    public class InvItemTransactionDetailsResponseDto
    {
        public Guid Id { get; set; }
        public string? AutoGenCode { get; set; }
        public Guid TransactionMasterId { get; set; }
        public string TransactionMasterName { get; set; }
        public Guid? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public Guid? ProductId { get; set; }
        public Guid ItemId { get; set; }
        public string ItemName { get; set; }
        public Guid UnitId { get; set; }
        public string UnitName { get; set; }
        public Guid StoreId { get; set; }
        public string StoreName { get; set; }
        public string? ModelNo { get; set; }
        public string? StyleNo { get; set; }
        public string? SKUNo { get; set; }
        public string BarCode { get; set; }
        public double Quantity { get; set; }
        public double AvailableQty { get; set; }
        public double UnitPrice { get; set; }
        public double ItemDiscountPrice { get; set; }
        public double SalePrice { get; set; }
        public double DiscountAmount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool IsActive { get; set; }
        public float AvailableQuantity { get; set; }
    }
}
