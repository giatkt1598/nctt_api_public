using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using static DataService.Commons.Constants;

namespace WebApi.Extensions
{
    public static class ControllerBaseExtention
    {
       public static void SetRefreshTokenCookie(this ControllerBase controller, string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };
            controller.Response.Cookies.Append("refreshToken", token, cookieOptions);
        }
    }
}
