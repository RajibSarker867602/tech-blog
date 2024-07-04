using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public class AccountsProjectChequeRegisterUpdateRequestDto
    {
        public Guid? Id { get; set; }
        [Required(ErrorMessage = "Cheque number is required")]
        public string SerialNumber { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
    }
}
