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

        public DbSet<Puzzle> Puzzles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<OrderList> OrderLists { get; set; }
    }
}