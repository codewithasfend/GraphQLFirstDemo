using GraphQL;
using GraphQL.Types;
using GraphQLProject1.Models;
using GraphQLProject1.Repositories;
using GraphQLProject1.Type;

namespace GraphQLProject1.Mutation
{
    public class BookMutation : ObjectGraphType
    {
        public BookMutation(IBookRepository bookRepository)
        {
            
            Field<BookType>("addBook").Arguments(new QueryArguments(new QueryArgument<BookInputType> { Name = "book" }))
             .Resolve(context =>
             {
                 return bookRepository.AddBook(context.GetArgument<Book>("book"));
             });

        }
    }
}
