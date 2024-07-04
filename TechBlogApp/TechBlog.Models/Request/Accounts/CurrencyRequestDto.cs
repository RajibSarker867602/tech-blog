using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public record CurrencyRequestDto
    {
        [Required]
        public string CurrencyName { get; set; }
        [Required]
        public string CurrencyType { get; set; }
        public double? Conversion { get; set; }
        public bool IsActive { get; set; }
    }
}
