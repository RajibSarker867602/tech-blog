﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.Request.Security.User
{
    public class TokenModelDto
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }

    }
}
