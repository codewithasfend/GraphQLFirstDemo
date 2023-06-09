using GraphQLProject1.Models;

namespace GraphQLProject1.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();   
        List<Book> GetBooksByAuthor(int authorId);  
        Book AddBook(Book book);    
    }
}
