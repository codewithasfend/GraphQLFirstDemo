using GraphQL.Types;
using GraphQLProject1.Models;
using GraphQLProject1.Repositories;

namespace GraphQLProject1.Type
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType(IBookRepository bookRepository)
        {
            Field(v => v.Id);
            Field(v => v.Name);
            Field(v => v.Age);
            Field(v => v.Gender);
            Field<ListGraphType<BookType>>("books").Resolve(context =>
            {
                return bookRepository.GetBooksByAuthor(context.Source.Id);
            });
        }
    }
}
