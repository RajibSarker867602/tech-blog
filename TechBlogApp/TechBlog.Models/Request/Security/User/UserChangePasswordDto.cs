using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Security.User
{
    public class UserChangePasswordDto
    {
        //public Guid? Id { get; set; }
        [Required]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Old password is required")]
        public string OldPassword { get; set; } = string.Empty;
        [Required(ErrorMessage = "New password is required")]
        public string NewPassword { get; set; } = string.Empty;
        [Required(ErrorMessage = "Confirm password is required")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
