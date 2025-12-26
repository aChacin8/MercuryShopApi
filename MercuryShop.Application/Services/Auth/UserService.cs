using MercuryShop.Application.DTOs.Auth;
using MercuryShop.Application.Interfaces.Auth;
using MercuryShop.Domain.Entities;

namespace MercuryShop.Application.Services.Auth
{
    public class UserService : IUserService
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

        public async Task RegisterUser(RegisterUserDto registerUserDto)
        {
            var existing = await _userRepository.GetByEmailAsync(registerUserDto.Email);

            if(existing != null)
                throw new Exception ("Email already exists");

            var hashedPassword = _passwordHash.HashPassword(registerUserDto.Password);

            var user = new User (registerUserDto.FirstName, registerUserDto.LastName, registerUserDto.Email, hashedPassword, registerUserDto.Address, registerUserDto.PhoneNumber);

            await _userRepository.AddAsync(user);
        }

        public async Task<string> LoginUser (LoginUserDto loginUserDto)
        {
            var user = await _userRepository.GetByEmailAsync(loginUserDto.Email);

            if(user == null)
                throw new UnauthorizedAccessException ("Invalid Credentials");

            var isValid = _passwordHash.VerifyPassword(loginUserDto.Password, user.PasswordHash);

            if(!isValid)
                throw new UnauthorizedAccessException ("Invalid Credentials");
            
            var identity = new UserClaims
            {
                Id = user.Id,
                Email = user.Email
            };
            return _jwtService.GenerateToken(identity);
        }

        public async Task <string> UpdateUser(UpdateUserDto)
        {
            var user = await _userRepository
        }
    }
}