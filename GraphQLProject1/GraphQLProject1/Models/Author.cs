namespace GraphQLProject1.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public ICollection<Book> Books { get; set; }    
    }
}
