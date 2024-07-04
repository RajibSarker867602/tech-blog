using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts.Bank
{
    public class AccountsBankChequeForwardUpdateDto
    {
        [Required(ErrorMessage = "Amount is required")]
        public double Amount { get; set; }
        [Required(ErrorMessage = "Place date is required")]
        [DataType(DataType.DateTime, ErrorMessage = "Place date should be date time only")]
        public DateTime PlaceDate { get; set; }
        [Required(ErrorMessage = "Delivered status is required")]
        public bool IsDelivered { get; set; }
        [Required(ErrorMessage = "Narration is required")]
        public string? Narration { get; set; }
        public Guid? CurrencyId { get; set; }
        public Double? ConvertionRate { get; set; }
    }
}
