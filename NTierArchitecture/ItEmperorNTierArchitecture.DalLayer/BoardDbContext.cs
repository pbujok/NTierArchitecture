using ItEmperorNTierArchitecture.DalLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItEmperorNTierArchitecture.DalLayer
{
    public class BoardDbContext : DbContext
    {
        public BoardDbContext(DbContextOptions<BoardDbContext> options) : base(options)
        {
        }
        
        public DbSet<Comment> Comments { get; set; }
    }
}