using GraphQLProject1.Data;
using GraphQLProject1.Models;

namespace GraphQLProject1.Repositories
{

    public class AuthorRepository : IAuthorRepository
    {

        private readonly ApiDbContext dbContext;
        public AuthorRepository(ApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Author> GetAllAuthors()
        {
            return dbContext.Authors.ToList();
        }

        public Author AddAuthor(Author author)
        {
            dbContext.Authors.Add(author);
            dbContext.SaveChanges();
            return author;
        }
    }

}
