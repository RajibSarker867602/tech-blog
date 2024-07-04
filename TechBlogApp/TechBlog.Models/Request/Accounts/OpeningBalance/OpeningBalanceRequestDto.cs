using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.OpeningBalance
{
    public class OpeningBalanceRequestDto
    {
        [Required(ErrorMessage = "Transaction type is required")]
        public string TransactionType { get; set; }

        [Required(ErrorMessage = "Opening date is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Opening date should be date time only")]
        public DateTime OpeningDate { get; set; }
    }
}
