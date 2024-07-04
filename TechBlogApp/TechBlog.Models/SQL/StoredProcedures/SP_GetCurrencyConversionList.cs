using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures
{
    public record SP_GetCurrencyConversionList
    {
        public Guid Id { get; set; }
        public Guid ConversionId { get; set; }
        public Guid FromCurrencyId { get; set; }
        public Guid ToCurrencyId { get; set; }
        public string ForeignCurrency { get; set; }
        public string LocalCurrency { get; set; }
        public double ConversionRate { get; set; }
        public bool IsActive { get; set; }
    }
}
