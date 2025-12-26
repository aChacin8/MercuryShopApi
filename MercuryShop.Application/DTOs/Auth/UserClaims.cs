namespace MercuryShop.Application.DTOs.Auth
{
    public class UserClaims
    {
        public int Id { get; init; }
        public string Email { get; init; } = default!;
    }
}
