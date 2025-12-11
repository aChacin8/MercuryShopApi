namespace MercuryShop.Application.DTOs
{
    public class LoginUserDto
    {
        public required string Email { get; init; }
        public required string Password { get; init; }
    }
}