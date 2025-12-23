namespace MercuryShop.Application.DTOs
{
    public class UserClaims
    {
        public Guid Id { get; init; }
        public string Email { get; init; } = default!;
    }
}
