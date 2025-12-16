using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

using MercuryShop.Domain.Entities;
using MercuryShop.Infrastructure.Data;
using MercuryShop.Application.Interfaces;


namespace MercuryShop.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MercuryShopDb _context;

        public UserRepository(MercuryShopDb context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetEmail (string email)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Email == email); //SingleOrDefault, para mantener unicidad, es decir email unico.
        }
    }
}