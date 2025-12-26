using MercuryShop.Application.DTOs.Auth;
using MercuryShop.Application.Services.Auth;

namespace MercuryShop.Application.Interfaces.Auth
{
    public interface IUserService
    {
        Task RegisterUser(RegisterUserDto registerUserDto);
        Task<string> LoginUser (LoginUserDto loginUserDto);
    }
}