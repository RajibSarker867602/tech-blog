using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.User
{
    /// <summary>
    /// An user group with few properties
    /// </summary>
    public class UserGroupDataResponseDto
    {
        /// <summary>
        /// Serial no of the user group
        /// </summary>
        public int SL { get; set; }

        /// <summary>
        /// User id for the user group
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// User name for the user group
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// User group id
        /// </summary>
        public Guid GroupId { get; set; }

        /// <summary>
        /// User group name
        /// </summary>
        public string UserGroup { get; set; }

        /// <summary>
        /// Is the group is active or not(True/False)
        /// </summary>
        public bool IsGroupActive { get; set; }

        /// <summary>
        /// User group status
        /// </summary>
        public string Status { get; set; }
    }
}
