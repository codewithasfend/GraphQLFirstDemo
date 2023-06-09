using GraphQL;
using GraphQL.Types;
using GraphQLProject1.Repositories;
using GraphQLProject1.Type;

namespace GraphQLProject1.Query
{
    public class BookQuery : ObjectGraphType
    {
        public BookQuery(IBookRepository bookRepository)
        {
            Field<ListGraphType<BookType>>("books").Resolve(context =>
            {
                return bookRepository.GetAllBooks();
            });

            Field<ListGraphType<BookType>>("book").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "authorId" }))
            .Resolve(context =>
            {
                return bookRepository.GetBooksByAuthor(context.GetArgument<int>("authorId"));
            });
        }
    }
}
