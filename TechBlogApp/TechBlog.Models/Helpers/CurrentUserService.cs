using LeadingEdgeServer.Models.Common;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using TechBlog.Models.Helpers.Contracts;

namespace TechBlog.Models.Helpers
{
    public class CurrentUserService
    {
        private static IHttpContextAccessor _httpContextAccessor;
        private static ICacheService _memoryCache;

        public static void Configure(IHttpContextAccessor httpContextAccessor, ICacheService memoryCache)
        {
            _httpContextAccessor = httpContextAccessor;
            _memoryCache = memoryCache;
        }

        public static Nullable<Guid> UserId
        {
            get
            {
                var id = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
                if (id != null)
                {
                    Guid userId = Guid.Empty;
                    Guid.TryParse(id.Value, out userId);
                    return userId;
                }
                return null;
            }
        }

        public static string UserName
        {
            get
            {
                return _httpContextAccessor.HttpContext.User.Identity.Name ?? String.Empty;
            }
        }

        public static DateTime? GetTokenExpireTime
        {
            get
            {
                var exp = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "exp").Value;
                if (exp != null)
                {
                    if (long.TryParse(exp, out long expValue))
                    {
                        return expValue.UnixTimeStampToDateTime();
                    }
                }
                return null;
            }
        }

        public static Nullable<Guid> ProjectId
        {
            get
            {
                var id = _httpContextAccessor.HttpContext?.Request.Headers["ProjectId"].ToString();
                if (id != null)
                {
                    Guid projectId = Guid.Empty;
                    Guid.TryParse(id, out projectId);
                    return projectId;
                }
                return null;
            }
        }
    }
}