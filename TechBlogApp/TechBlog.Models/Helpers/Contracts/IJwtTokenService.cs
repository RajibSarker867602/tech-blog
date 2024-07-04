using LeadingEdgeServer.Models.Request.User;
using LeadingEdgeServer.Models.Response.Auth;
using LeadingEdgeServer.Models.Response.MenuModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TechBlog.Models.Helpers.Contracts
{
    public interface IJwtTokenService
    {
        TokenResponseDto Generatetoken(UserLoginDto model, Guid userId, UserMenusReturnContainerDto userPermissions);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
    }
}
