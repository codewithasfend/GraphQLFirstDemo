using GraphQLProject1.Models;

namespace GraphQLProject1.Repositories
{
    public interface IAuthorRepository
    {
        List<Author> GetAllAuthors();   
        Author AddAuthor(Author author);
    }
}
