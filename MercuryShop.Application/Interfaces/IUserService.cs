using MercuryShop.Application.DTOs;
using MercuryShop.Application.Services;

namespace MercuryShop.Application.Interfaces
{
    public interface IUserService
    {
        Task RegisterUser(RegisterUserDto registerUserDto);
        Task<string> LoginUser (LoginUserDto loginUserDto);
    }
}