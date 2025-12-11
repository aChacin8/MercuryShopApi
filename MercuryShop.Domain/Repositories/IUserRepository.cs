using MercuryShop.Domain.Entities;

namespace MercuryShop.Domain.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
    }
}