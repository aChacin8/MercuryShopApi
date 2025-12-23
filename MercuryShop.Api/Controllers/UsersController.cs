using Microsoft.AspNetCore.Mvc;

using MercuryShop.Application.Interfaces;
using MercuryShop.Application.DTOs;
using MercuryShop.Domain.Entities;

namespace MercuryShop.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersControllers : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersControllers(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task <IActionResult> Register (RegisterUserDto registerUserDto)
        {
            await _userService.RegisterUser(registerUserDto);
            return Ok(new
            {
                message = "User registered succesfully"
            });
        }

        [HttpPost("login")]
        public async Task <IActionResult> Login (LoginUserDto loginUserDto)
        {
            var token = await _userService.LoginUser(loginUserDto);
            return Ok(new
            {
                token,
                message = "User login succesfully"
            });
        }
    }
}