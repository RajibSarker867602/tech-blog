using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using TechBlog.Models.Helpers.Contracts;

namespace LeadingEdgeServer.Models.Helpers
{
    public class JwtTokenService : IJwtTokenService
    {
        private readonly IConfiguration _configuration;
        private int _accessTokeExpireTimeInMinutes = 0;
        private int _refreshTokenExpireTimeInDays = 0;

        public JwtTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
            _accessTokeExpireTimeInMinutes = int.Parse(_configuration.GetSection("Jwt:Access_Token_ExpireTime_In_Minutes").Value);
            _refreshTokenExpireTimeInDays = int.Parse(_configuration.GetSection("Jwt:Refresh_Token_ExpireTime_InDay").Value);
        }

        // public TokenResponseDto Generatetoken(UserLoginDto model, Guid userId, UserMenusReturnContainerDto userPermissions)
        // {
        //     var claims = new[]
        //     {
        //         new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
        //         new Claim(ClaimTypes.Name, model.UserName),
        //         //new Claim("user-menus", JsonSerializer.Serialize(userPermissions.UserMenus).GetMD5EncryptedText()),
        //         //new Claim("user-reports", JsonSerializer.Serialize(userPermissions.UserReportMenus).GetMD5EncryptedText()),
        //     };
        //
        //     var key = new SymmetricSecurityKey(
        //         Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:Key").Value));
        //     var creates = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
        //     SecurityTokenDescriptor tokenDescription = new SecurityTokenDescriptor();
        //     tokenDescription = new SecurityTokenDescriptor
        //     {
        //         Subject = new ClaimsIdentity(claims),
        //         Issuer = _configuration.GetSection("Jwt:Issuer").Value,
        //         Audience = _configuration.GetSection("Jwt:Audience").Value,
        //         IssuedAt = DateTime.UtcNow,
        //         Expires = DateTime.UtcNow.AddMinutes(_accessTokeExpireTimeInMinutes),
        //         //Expires = DateTime.UtcNow.AddSeconds(10),
        //         SigningCredentials = creates,
        //     };
        //
        //     var tokenHandler = new JwtSecurityTokenHandler();
        //     var token = tokenHandler.CreateToken(tokenDescription);
        //
        //     var refreshToken = GenerateRefreshToken();
        //
        //     var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
        //
        //     return new TokenResponseDto
        //     {
        //         Token = tokenString,
        //         ExpireDateTime = token.ValidTo,
        //         RefreshToken = refreshToken,
        //         RefreshExpireDateTime = token.ValidTo.AddDays(_refreshTokenExpireTimeInDays),
        //         //RefreshExpireDateTime = token.ValidTo
        //     };
        // }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        public ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token)
        {
            var key = _configuration.GetSection("Jwt:Key").Value;
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = false,
                ClockSkew = TimeSpan.Zero
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var data = tokenHandler.ReadToken(token);

            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            JwtSecurityToken jwtSecurityToken = securityToken as JwtSecurityToken;

            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha512, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }

            return principal;
        }
    }
}