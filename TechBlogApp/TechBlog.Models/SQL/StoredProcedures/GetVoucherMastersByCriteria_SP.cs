using LeadingEdgeServer.Models.Common;
using LeadingEdgeServer.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures
{
    public record GetVoucherMastersByCriteria_SP
    {
        public int SL { get; set; }
        public Guid? Id { get; set; }
        public string? VoucherNo { get; set; }
        public DateTime VoucherDate { get; set;}
        public string? Narration { get; set;}
        public string? ProjectName { get; set; }
        public string? ProjectCode { get; set;}
        public string? FascialYearName { get; set;}
        public ApprovalTypeEnum StatusId { get; set;}
        public string? StatusName => StatusId.GetEnumTitle(true);
        public Decimal? Balance { get; set; }
        public bool? IsFiscialYearClosed { get; set; }
        public double CurrencyAmount { get; set; }
        public double ConvertionRate { get; set; }
        public string CurrencyName { get; set; }
        public long? RowNumber { get; set; }
    }
}
