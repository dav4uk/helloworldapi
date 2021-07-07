using System.Collections.Generic;
using System.Linq;
using BookStore.Data.Interfaces;
using BookStore.Data.Models;

namespace BookStore.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> books = new List<Book>()
        {
            new Book {Id = 1, Author = "Roaling", Title = "Harry Potter"},
            new Book {Id = 2, Author = "Kokotyuha", Title = "Rad"},
            new Book {Id = 3, Author = "Shevchenko", Title = "Kobzar"},
            new Book {Id = 4, Author = "Kokotyuha", Title = "Chornyi voron"},
            new Book {Id = 5, Author = "Franko", Title = "Kamenyari"},
        };
        
        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }
    }
}