using System.Collections.Generic;
using System.Linq;
using BookStore.Data.Interfaces;
using BookStore.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using BookStore.Data.Models;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BookRepository books = new BookRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBooks();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }

            return book;
        }
    }
}