using Microsoft.EntityFrameworkCore;

namespace Wati.Api.Models
{
    public class AddContext : DbContext
    {
        public AddContext(DbContextOptions<AddContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Addition> AddNumbers { get; set; }
    }
}
