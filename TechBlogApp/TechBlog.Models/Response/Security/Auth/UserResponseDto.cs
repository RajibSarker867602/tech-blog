using LeadingEdgeServer.Models.Response.MenuModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Auth
{
    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public bool IsSuccess { get; set; }
        public string UserName { get; set; }
        public IEnumerable<string> Errors { set; get; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? RefreshTokenExpireDate { get; set; }
        public string CompanyTheme { get; set; }
        public UserMenusReturnContainerDto Menus{ get; set; }
    }

    public class UserTokenResponseDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
