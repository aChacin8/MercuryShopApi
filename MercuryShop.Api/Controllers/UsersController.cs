using Microsoft.AspNetCore.Mvc;

using MercuryShop.Application.Interfaces;
using MercuryShop.Application.DTOs;

namespace MercuryShop.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersControllers : ControllerBase
    {
        private readonly IUserRepository _userRepository;
    }
}