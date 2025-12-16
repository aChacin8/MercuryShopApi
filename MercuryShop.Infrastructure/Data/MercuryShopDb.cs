using Microsoft.EntityFrameworkCore;

using MercuryShop.Domain.Entities;

namespace MercuryShop.Infrastructure.Data
{
    public class MercuryShopDb : DbContext
    {
        public MercuryShopDb(DbContextOptions<MercuryShopDb> options) : base(options)
        {
            
        }
    }
}