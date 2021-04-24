using Bookstore.Entities;
using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.API.Controllers
{
    [Route("api/book")] //...../api/book/
    [ApiController]
    public class BookAPIController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BookAPIController> _logger;

        public BookAPIController(IBookService bookService, ILogger<BookAPIController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        [HttpGet("GetBooks")]
        public IEnumerable<Book> GetBooks()
        {
            var bookList = _bookService.GetAllBooks();
            return bookList;
        }

        [HttpGet("{id}")] //api/book/id --> Primer --> api/book/3 i ke zeme book so id 3
        public ActionResult GetBook(int id)
        {
            var book = _bookService.GetBookById(id);
            return Ok(book);
        }

        [HttpGet("RandomBook")]
        public Book GetRandomBook() // api/book/randombook
        {
            var findBook = _bookService.GetBookById(new Random().Next(1, _bookService.GetAllBooks().Max(book => book.Id)));
            if (findBook == null)
            {
                do
                {
                    findBook = _bookService.GetBookById(new Random().Next(1, _bookService.GetAllBooks().Max(book => book.Id)));
                } while (findBook == null);
            }
            return findBook;
        }
    }
}
