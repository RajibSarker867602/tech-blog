using LeadingEdgeServer.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.User
{
    public class UserGroupRequestDto
    {
        public UserGroupRequestDto()
        {
            UserGroupProjectIds = new List<Guid>();
        }
        public Nullable<Guid> Id { get; set; }
        [Required(ErrorMessage = "User group name is required.")]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Guid> UserGroupProjectIds { get; set; }
    }
}
