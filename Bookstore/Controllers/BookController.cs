using Bookstore.Entities;
using Bookstore.Entities.Logger;
using Bookstore.Models;
using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;
        private readonly IPublisherService _publisherService;
        private readonly ILogger<BookController> _logger;

        public BookController(
            IBookService bookService,
            IAuthorService authorService,
            ICategoryService categoryService,
            IPublisherService publisherService,
            ILogger<BookController> logger)
        {
            this._bookService = bookService;
            this._authorService = authorService;
            this._categoryService = categoryService;
            this._publisherService = publisherService;
            this._logger = logger;
        }
        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            _logger.LogInformation(LoggerMessageDisplay.BooksListed);

            return View(books);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var categories = _categoryService.GetAllCategories();
            var authors = _authorService.GetAllAuthors();
            var publishers = _publisherService.GetAllPublishers();

            var dropdowns = _bookService.FillDropdowns(categories, authors, publishers);

            ViewBag.CategoryList = dropdowns.Categories;
            ViewBag.AuthorList = dropdowns.Authors;
            ViewBag.PublisherList = dropdowns.Publishers;

            return View();
        }

        [HttpPost]
        public IActionResult Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var author = new Author();

                //author.Name = model.AuthorNameDTO;
                //author.Country = model.AuthorCountryDTO;
                //author.DateBirth = model.AuthorDateBirthDTO;
                //author.Gender = model.AuthorGenderDTO;
                //author.Language = model.AuthorLanguageDTO;
                //author.Popularity = model.AuthorPopularityDTO;
                //author.ShortDescription = model.AuthorShortDescriptionDTO;

                //_authorService.Add(author);
                //,, --> vaka moze i za category i za publisher

            }

            var book = new Book();
            book.Title = model.BookTitle;
            book.AuthorID = model.AuthorID;
            book.AuthorName = model.AuthorName;
            book.BookCoverType = model.BookCoverType;
            book.BookType = model.BookType;
            book.CategoryID = model.CategoryID;
            book.CategoryName = model.CategoryName;
            book.Copies = model.Copies;
            book.Country = model.Country;
            book.DateAdded = DateTime.Now;
            book.Description = model.Description;
            book.Edition = model.Edition;
            book.Genre = model.Genre;
            book.Language = model.Language;
            book.NumberOfPages = model.NumberOfPages;
            book.PhotoURL = model.PhotoURL;
            book.Price = model.Price;
            book.PublisherID = model.PublisherID;
            book.PublisherName = model.PublisherName;
            book.Rating = model.Rating;
            book.Shipping = model.Shipping;
            book.SoldItems = model.SoldItems;
            book.Weight = model.Weight;
            book.YearOfIssue = model.YearOfIssue;
            book.Dimensions = model.Dimensions;

            _bookService.Add(book);
            _logger.LogInformation(LoggerMessageDisplay.BookCreated);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            var book = _bookService.GetBookById(id);

            var categories = _categoryService.GetAllCategories();
            var authors = _authorService.GetAllAuthors();
            var publishers = _publisherService.GetAllPublishers();

            var dropdowns = _bookService.FillDropdowns(categories, authors, publishers);

            ViewBag.CategoryList = dropdowns.Categories;
            ViewBag.AuthorList = dropdowns.Authors;
            ViewBag.PublisherList = dropdowns.Publishers;

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book, int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _bookService.Edit(book);
                    _logger.LogInformation(LoggerMessageDisplay.BookEdited);

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    _logger.LogError(LoggerMessageDisplay.BookEditErrorModelStateInvalid);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.BookEditNotFound + " | " + ex);
                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var book = _bookService.GetBookById(id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = _bookService.GetBookById(id);
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _bookService.GetBookById(id);
            _bookService.Delete(book.Id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public JsonResult GetAllBooksAJAX()
        {
            var allBooks = _bookService.GetAllBooks();
            return Json(new { booksData = allBooks });
        }

        [HttpPost]

        public IActionResult UploadPhoto()
        {
            try
            {
                var file = Request.Form.Files[0];

                var folderName = Path.Combine("wwwroot", "photos");

                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    //gi kratime navodnicite na imeto, so ova ke vrati samo ime
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);

                    var dbPath = fileName;

                    // 1. targetWhereToCopy --> stream
                    // 2. copy contents of uploaded file in our case "file" to the target stream 

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    return Ok(new { dbPath }); //Status 200 ok response 
                }
                else
                {
                    return BadRequest(); //Status 400 bad requst 
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex);
            }
        }


    }
}
