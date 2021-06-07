using DataService.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Models.ResponseModels
{
    public class AuthenticateResponse
    {
        public UserViewModel User { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
