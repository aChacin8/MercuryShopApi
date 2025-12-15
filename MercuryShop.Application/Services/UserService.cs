using MercuryShop.Application.DTOs;
using MercuryShop.Application.Interfaces;
using MercuryShop.Domain.Entities;

namespace MercuryShop.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository; 
        private readonly IPasswordHasher _passwordHash;
        private readonly IJwtService _jwtService;

        public UserService(IUserRepository userRepository, IPasswordHasher passwordHash, IJwtService jwtService)
        {
            _userRepository = userRepository;
            _passwordHash = passwordHash;
            _jwtService = jwtService; 
        }

        // public async Task<string> RegisterUser(RegisterUserDto registerUserDto)
        // {
            
        // }
    }
}