using DataService.Models.RequestModels;
using DataService.Models.ResponseModels;
using DataService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Extensions;
using WebApi.Models.RequestModels;
using WebApi.Models.ResponseModels;

namespace WebApi.Controllers
{
    [Route("users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        ///     Login
        /// </summary>
        [HttpPost("authenticate")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AuthenticateResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        public async Task<IActionResult> Authenticate(AuthenticateRequest model)
        {
            AuthenticateResponse response = await _userService.Authenticate(model);
            if (response == null)
            {
                return BadRequest(new ErrorResponse
                {
                    Status = 400,
                    Title = "Username or password is incorrect"
                });
            }
            this.SetRefreshTokenCookie(response.RefreshToken);
            return Ok(response);
        }

        /// <summary>
        ///     Get new token
        /// </summary>
        /// <remarks>
        ///     Pass 'refresh token' by cookie or model, model first.
        ///     Refresh token hiện tại có được từ việc encoding và decoding nên chỉ cần bị 
        ///     lộ thì trừ khi refresh token hết hạn hoặc account bị xóa nếu ko là sài vĩnh viễn luôn. 
        ///     Kiến nghị lưu refresh token vào database để cho phép 
        ///     revoke (thu hồi) refresh token khi không sử dụng. Như vậy, nếu access_token hết hạn 
        ///     (access_token có hạn sử dụng ngắn dưới 5 phút)
        ///     thì chỉ có thể đăng nhập bằng username password mới có thể tiếp tục truy cập.
        /// </remarks>
        /// <returns></returns>
        [HttpPost("refresh-token")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AuthenticateResponse))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(ErrorResponse))]
        public async Task<IActionResult> RefreshToken(RefreshToken model)
        {
            string refreshToken = model?.Token;
            if (string.IsNullOrEmpty(refreshToken))
            {
                refreshToken = Request.Cookies["refreshToken"];
            }
            AuthenticateResponse response = await _userService.RefreshToken(refreshToken);
            if (response == null)
            {
                return Unauthorized(new ErrorResponse
                {
                    Status = 401,
                    Title = "Invalid Token"
                });
            }
            this.SetRefreshTokenCookie(response.RefreshToken);
            return Ok(response);
        }
    }
}
