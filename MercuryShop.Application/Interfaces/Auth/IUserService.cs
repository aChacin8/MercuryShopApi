using MercuryShop.Application.DTOs.Auth;
using MercuryShop.Application.Services.Auth;

namespace MercuryShop.Application.Interfaces.Auth
{
    public interface IUserService
    {
        Task<string?> RegisterUser(RegisterUserDto registerUserDto);
        Task<string> LoginUser (LoginUserDto loginUserDto);

        Task <string?> UpdateUser (UpdateUserDto updateUserDto);
    }
}