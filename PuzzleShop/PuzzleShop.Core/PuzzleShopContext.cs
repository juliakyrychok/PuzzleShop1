using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PuzzleShop.Core
{
    public class PuzzleShopContext : IdentityDbContext<User>
    {
        public PuzzleShopContext(DbContextOptions<PuzzleShopContext> options)
            : base(options)
        {
        }
    }
}