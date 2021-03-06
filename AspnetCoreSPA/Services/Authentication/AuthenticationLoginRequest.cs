﻿using AspnetCoreSPATemplate.Services.Common;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreSPATemplate.Services.Authentication
{
    [BindProperties(SupportsGet = true)]
    public class AuthenticationLoginRequest : RequestBase
    {
        public AuthenticationLoginRequest()
            : base()
        {
        }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}