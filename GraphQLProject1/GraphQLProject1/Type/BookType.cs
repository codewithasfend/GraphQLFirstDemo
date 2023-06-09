using GraphQL.Types;
using GraphQLProject1.Models;

namespace GraphQLProject1.Type
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType() 
        {
            Field(v => v.Id);
            Field(v => v.Title);
            Field(v => v.Price);
            Field(v => v.TotalPages);
            Field(v => v.AuthorId);
        }
    }
}
