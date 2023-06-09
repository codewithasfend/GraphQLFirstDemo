using GraphQL.Types;

namespace GraphQLProject1.Type
{
    public class AuthorInputType : InputObjectGraphType
    {
        public AuthorInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<IntGraphType>("age");
            Field<StringGraphType>("gender");

        }
    }
}
