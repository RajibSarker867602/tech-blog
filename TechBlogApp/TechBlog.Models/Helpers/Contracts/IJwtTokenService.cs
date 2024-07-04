using System.Security.Claims;

namespace TechBlog.Models.Helpers.Contracts
{
    public interface IJwtTokenService
    {
        string GenerateRefreshToken();

        ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
    }
}