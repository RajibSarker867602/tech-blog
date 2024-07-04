using LeadingEdgeServer.Models.Common;
using LeadingEdgeServer.Models.Enum;
using LeadingEdgeServer.Models.Enum.AutoVoucher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures.Inventory
{
    public record SP_GetInventoryTransactionByCriteria
    {
        public int SL { get; set; }
        public Guid Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionCode { get; set; }
        public string PurchaseOrderCode { get; set; }
        public string? MasterAutoGenCode { get; set; }
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Store { get; set; }
        public PaymentModeEnum PaymentMode { get; set; }
        public string PaymentModeName => PaymentMode.GetEnumTitle(true);
        public TransactionModeEnum TransactionMode { get; set; }
        public string TransactionModeName => TransactionMode.GetEnumTitle(true);
        public double DiscountPercentage { get; set; }
        public double ItemTotalPrice { get; set; }
        public double ItemDiscount { get; set; }
        public double SpecialDiscount { get; set; }
        public double VatPercentage { get; set; }
        public double AdditionalCharge { get; set; }
        public double ItemPriceLineTotalDiscount { get; set; }
        public double TotalPercentageDiscount { get; set; }
        public double TotalDiscountItemPrice { get; set; }
        public double TotalPriceAfterDiscount { get; set; }
        public double Vat { get; set; }
        public double TotalVATPrice { get; set; }
        public double GrantTotal { get; set; }
        public Guid CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public double ConvertionRate { get; set; }
        public double TotalLocalPrice { get; set; }
        public ApprovalTypeEnum StatusId { get; set; }
        public string StatusName => StatusId.GetEnumTitle(true);
    }
}
