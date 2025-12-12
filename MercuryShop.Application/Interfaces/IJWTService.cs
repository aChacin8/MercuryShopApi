using MercuryShop.Application.DTOs;

namespace MercuryShop.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken (UserIdentity userIdentity);
    }
}