using GraphQL.Types;
using GraphQLProject1.Repositories;
using GraphQLProject1.Type;

namespace GraphQLProject1.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<BookQuery>("bookQuery").Resolve(context => new { });
            Field<AuthorQuery>("authorQuery").Resolve(context => new { });
        }
    }
}
