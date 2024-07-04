using LeadingEdgeServer.Models.Enum;
using LeadingEdgeServer.Models.Enum.AutoVoucher;
using LeadingEdgeServer.Models.Enum.Inventory;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Inventory.ItemTransactions
{
    public class InvItemTransactionMasterCreationDto
    {
        public InvItemTransactionMasterCreationDto()
        {
            TransactionDetails = new List<InvItemTransactionDetailsCreationDto>();
           // TransactionDetailsFinishedGoods = new List<InvItemTransactionDetailsCreationDto>();
        }
        public Guid? SupplierId { get; set; }
        public Guid? BuyerId { get; set; }

        [Required(ErrorMessage = "Transaction date is required.")]
        public DateTime TransactionDate { get; set; }
        public Guid? StoreId { get; set; }
        public Guid? TransactionId { get; set; }

        [Required(ErrorMessage = "Transaction type is required.")]
        public InvFeatureEnum TransactionType { get; set; }

        public string? ReferenceNo { get; set; }
        public Guid? FromStoreId { get; set; }
        public Guid? ToStoreId { get; set; }
        public IFormFile? File { get; set; }
        public string? FileUrl { get; set; }
        public PaymentModeEnum PaymentMode { get; set; }
        public TransactionModeEnum TransactionMode { get; set; }
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
        public Guid? SalesItemId { get; set; }
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }
        public double DiscountPercentage { get; set; }
        public double SpecialDiscount { get; set; }
        public double VatPercentage { get; set; }
        public double AdditionalCharge { get; set; }
        public Guid? CurrencyId { get; set; }
        public Double? ConvertionRate { get; set; }
        public ApprovalTypeEnum? StatusId { get; set; }
        public ICollection<InvItemTransactionDetailsCreationDto> TransactionDetails { get; set; }
        public ICollection<InvItemTransactionDetailsCreationDto>? TransactionDetailsFinishedGoods { get; set; }
    }

    public class InvItemTransactionDetailsCreationDto
    {
        public Guid? TransactionMasterId { get; set; }

        [Required(ErrorMessage = "Item is required.")]
        public Guid ItemId { get; set; }

        [Required(ErrorMessage = "Unit is required.")]
        public Guid UnitId { get; set; }

        public Guid? StoreId { get; set; }

        //[Required(ErrorMessage = "Barcode is required.")]
        public string? BarCode { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        public float Quantity { get; set; }

        public double? UnitPrice { get; set; }
        public double? SalePrice { get; set; }
        public double? DiscountAmount { get; set; }
        public double? TotalPrice { get; set; }
        public DiscountTypeEnum DiscountById { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool IsActive { get; set; }
    }
}
