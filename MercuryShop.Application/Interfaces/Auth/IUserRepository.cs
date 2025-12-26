using System.Threading.Tasks;

using MercuryShop.Domain.Entities;


namespace MercuryShop.Application.Interfaces.Auth
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task UpdateAsync (User user);
        Task <User?> GetByEmailAsync (string email);
        Task <User?> GetByIdAsync (int Id);
    }
}