using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Accounts
{
    public class AccountCOADeleteDto
    {
        public Guid? ProjectId { get; set; }
        [Required(ErrorMessage = "COA head id is required")]
        public Guid COAHeadId { get; set; }
    }
}
