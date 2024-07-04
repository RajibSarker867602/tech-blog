using LeadingEdgeServer.Models.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Accounts.Accounts
{
    public class CurrencyConversionResponseDto
    {
        public Guid Id { get; set; }
        public Guid FromCurrencyId { get; set; }
        //public CommonProjectCurrency FromCurrency { get; set; }
        public string FromCurrencyName { get; set; }
        public Guid ToCurrencyId { get; set; }
        public string ToCurrencyName { get; set; }
        //public CommonProjectCurrency ToCurrency { get; set; }
        public double ConversionRate { get; set; }
        public bool IsActive { get; set; }
    }
}
