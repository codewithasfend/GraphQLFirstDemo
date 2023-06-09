using GraphQL.Types;
using GraphQLProject1.Repositories;
using GraphQLProject1.Type;

namespace GraphQLProject1.Query
{
    public class AuthorQuery : ObjectGraphType
    {
        public AuthorQuery(IAuthorRepository authorRepository)
        {

            Field<ListGraphType<AuthorType>>("authors").Resolve(context =>
            {
                return authorRepository.GetAllAuthors();
            });

           
        }
    }
}
