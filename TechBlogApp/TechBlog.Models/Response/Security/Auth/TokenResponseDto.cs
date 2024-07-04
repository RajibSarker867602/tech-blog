using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Response.Auth
{
    public class TokenResponseDto
    {
        public DateTime ExpireDateTime { get; set; }
        public string Token { get; set; }
        public DateTime RefreshExpireDateTime { get; set; }
        public string RefreshToken { get; set; }
    }
}
