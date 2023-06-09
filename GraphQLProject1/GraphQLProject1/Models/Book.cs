namespace GraphQLProject1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public double Price { get; set; }
        public int TotalPages { get; set; }
        public int AuthorId { get; set; }   
    }
}
