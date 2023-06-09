using GraphQLProject1.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLProject1.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InMemoryDb");
        }
    }
}
