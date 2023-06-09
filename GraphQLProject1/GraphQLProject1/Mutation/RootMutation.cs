using GraphQL.Types;

namespace GraphQLProject1.Mutation
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<AuthorMutation>("authorMutation").Resolve(context => new { });
            Field<BookMutation>("bookMutation").Resolve(context => new { });


        }
    }
}
