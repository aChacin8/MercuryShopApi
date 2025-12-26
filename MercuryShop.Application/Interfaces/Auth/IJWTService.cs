using MercuryShop.Application.DTOs.Auth;

namespace MercuryShop.Application.Interfaces.Auth
{
    public interface IJwtService
    {
        string GenerateToken (UserClaims userClaims);
    }
}