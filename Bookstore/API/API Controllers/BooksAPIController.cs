using Bookstore.Entities;
using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public BooksAPIController(IBookService bookService)
        {
            this._bookService = bookService;
        }

        [HttpGet("Books")] // link --> ...../api/booksapi/books

        public IEnumerable<Book> GetBooks()
        {
            var books = _bookService.GetAllBooks();

            return books;
        }

    }
}
