using System.Collections.Generic;
using BookStore.Data.Models;

namespace BookStore.Data.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBook(int id);
    }
}