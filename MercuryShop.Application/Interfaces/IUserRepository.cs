using MercuryShop.Domain.Entities;
using System.Threading.Tasks;

namespace MercuryShop.Application.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
    }
}