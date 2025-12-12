using MercuryShop.Application.DTOs;

namespace MercuryShop.Application.Interfaces
{
    public interface IJWTService
    {
        string GenerateToken (UserIdentity userIdentity);
    }
}