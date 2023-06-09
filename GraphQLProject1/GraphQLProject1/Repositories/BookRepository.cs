using GraphQLProject1.Data;
using GraphQLProject1.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLProject1.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly ApiDbContext dbContext;
        public BookRepository(ApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Book> GetAllBooks()
        {
            return dbContext.Books.ToList();
        }

        public List<Book> GetBooksByAuthor(int authorId)
        {
            var books = dbContext.Books.Where(b => b.AuthorId == authorId);
            return books.ToList();
        }

        public Book AddBook(Book book)
        {
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
            return book;
        }
    }

}
