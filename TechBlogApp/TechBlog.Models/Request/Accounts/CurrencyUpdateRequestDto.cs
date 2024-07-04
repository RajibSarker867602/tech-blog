using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public record CurrencyUpdateRequestDto
    {
        public Guid Id { get; set; }
        public double ConversionRate { get; set; }
    }
}
