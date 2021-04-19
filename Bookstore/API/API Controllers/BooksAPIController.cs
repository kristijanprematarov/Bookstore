using Bookstore.Entities;
using Bookstore.Entities.API.Models;
using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.API.API_Controllers
{
    [Route("api/BooksAPI")]
    [ApiController]
    public class BooksAPIController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BooksAPIController> _logger;

        public BooksAPIController(IBookService bookService, ILogger<BooksAPIController> logger)
        {
            this._bookService = bookService;
            this._logger = logger;
        }

        [HttpGet("BooksData")] // link --> ...../api/booksapi/books

        public IEnumerable<Book> GetBooksFullData()
        {
            var books = _bookService.GetAllBooks();

            return books;
        }

        [HttpGet("Books")] // link --> ...../api/booksapi/books

        public IEnumerable<BookApiDTO> GetBooks()
        {
            var books = _bookService.GetAllBooksAPI();

            return books;
        }

        [HttpGet("GetBook")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);

            if (book == null)
            {
                return NotFound(); // ili NotFound() ili NoContent()
            }

            return Ok(book); //OK --> status code 200 success found
        }

        [HttpGet("BookTest1")]
        public ActionResult<Book> BookTest(int id, string testString)
        {
            if (testString == "KristijanTestiranje")
            {
                _logger.LogInformation("Get Request from BookTest1 with parameters {0} and {1}", id, testString);
                return Ok();

            }
            else
            {
                _logger.LogError("Bad Request from BookTest1 with parameters {0} and {1}", id, testString);
                _logger.LogWarning("Bad Request from BookTest1 with parameters {0} and {1}", id, testString);
                return BadRequest();
            }
        }

        [HttpPost("AddBook")]
        public ActionResult<Book> AddBook(Book book)
        {
            _bookService.Add(book);

            return CreatedAtAction("AddBook", new { id = book.Id, book }); //id-to + celiot objekt od knigata
        }
    }
}
