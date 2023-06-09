using GraphQLProject1.Models;

namespace GraphQLProject1

{
    public static class LibraryData
    {
        public static List<Author> Authors { get; } = new List<Author>
        {
        new Author
        {
            Id = 1,
            Name = "John Doe",
            Age = 35,
            Gender = "Male",
            Books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Price = 19.99,
                    TotalPages = 200,
                    AuthorId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    Price = 24.99,
                    TotalPages = 300,
                    AuthorId = 1
                }
            }
        },
        new Author
        {
            Id = 2,
            Name = "Jane Smith",
            Age = 28,
            Gender = "Female",
            Books = new List<Book>
            {
                new Book
                {
                    Id = 3,
                    Title = "Pride and Prejudice",
                    Price = 14.99,
                    TotalPages = 150,
                    AuthorId = 2
                },
                new Book
                {
                    Id = 4,
                    Title = "1984",
                    Price = 29.99,
                    TotalPages = 400,
                    AuthorId = 2
                }
            }
        },
        new Author
        {
            Id = 3,
            Name = "Michael Johnson",
            Age = 42,
            Gender = "Male",
            Books = new List<Book>
            {
                new Book
                {
                    Id = 5,
                    Title = "The Catcher in the Rye",
                    Price = 9.99,
                    TotalPages = 100,
                    AuthorId = 3
                }
            }
        },
        new Author
        {
            Id = 4,
            Name = "Emily Davis",
            Age = 31,
            Gender = "Female",
            Books = new List<Book>
            {
                new Book
                {
                    Id = 6,
                    Title = "To the Lighthouse",
                    Price = 12.99,
                    TotalPages = 250,
                    AuthorId = 4
                },
                new Book
                {
                    Id = 7,
                    Title = "Brave New World",
                    Price = 18.99,
                    TotalPages = 180,
                    AuthorId = 4
                }
            }
        },
        new Author
        {
            Id = 5,
            Name = "David Wilson",
            Age = 39,
            Gender = "Male",
            Books = new List<Book>
            {
                new Book
                {
                    Id = 8,
                    Title = "The Lord of the Rings",
                    Price = 15.99,
                    TotalPages = 220,
                    AuthorId = 5
                },
                new Book
                {
                    Id = 9,
                    Title = "Harry Potter and the Sorcerer's Stone",
                    Price = 21.99,
                    TotalPages = 320,
                    AuthorId = 5
                },
                new Book
                {
                    Id = 10,
                    Title = "Moby-Dick",
                    Price = 27.99,
                    TotalPages = 350,
                    AuthorId = 5
                }
            }
        }
    };
    }

}