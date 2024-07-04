using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.VoucherEntry
{
    public record AccountsVoucherListDateResponseDto
    {
        public int SL { get; set; }
        public Guid? Id { get; set; }
        public string? VoucherNo { get; set; }
        public DateTime VoucherDate { get; set; }
        public string? Narration { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectCode { get; set; }
        public string? FascialYearName { get; set; }
        public string? VoucherStatus { get; set; }
        public Decimal? Balance { get; set; }
        public bool? IsFiscialYearClosed { get; set; }
        public double CurrencyAmount { get; set; }
        public double ConvertionRate { get; set; }
        public string CurrencyName { get; set; }
        public long? RowNumber { get; set; }
    }
}
