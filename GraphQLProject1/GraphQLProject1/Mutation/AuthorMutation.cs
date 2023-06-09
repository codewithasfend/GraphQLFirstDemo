using GraphQL;
using GraphQL.Types;
using GraphQLProject1.Models;
using GraphQLProject1.Repositories;
using GraphQLProject1.Type;

namespace GraphQLProject1.Mutation
{
    public class AuthorMutation : ObjectGraphType
    {
        public AuthorMutation(IAuthorRepository authorRepository)
        {
            Field<AuthorType>("addAuthor").Arguments(new QueryArguments(new QueryArgument<AuthorInputType> { Name = "author" }))
                .Resolve(context =>
                {
                    return authorRepository.AddAuthor(context.GetArgument<Author>("author"));
                });


        }
    }
}
