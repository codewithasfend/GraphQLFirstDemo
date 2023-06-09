using GraphQL.Types;

namespace GraphQLProject1.Type
{
    public class BookInputType : InputObjectGraphType
    {
        public BookInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("title");
            Field<FloatGraphType>("price");
            Field<IntGraphType>("totalPages");
            Field<IntGraphType>("authorId");
        }
    }
}
