using System.Threading.Tasks;

using MercuryShop.Domain.Entities;


namespace MercuryShop.Application.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task <User?> GetEmail (string email);
    }
}