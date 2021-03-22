using Bookstore.Entities;
using Bookstore.Models;
using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;
        private readonly IPublisherService _publisherService;

        public BookController(
            IBookService bookService,
            IAuthorService authorService,
            ICategoryService categoryService,
            IPublisherService publisherService)
        {
            this._bookService = bookService;
            this._authorService = authorService;
            this._categoryService = categoryService;
            this._publisherService = publisherService;
        }
        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();

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
                book.PublisherName = model.PublisherName;
                book.Rating = model.Rating;
                book.Shipping = model.Shipping;
                book.SoldItems = model.SoldItems;
                book.Weight = model.Weight;
                book.YearOfIssue = model.YearOfIssue;
                book.Dimensions = model.Dimensions;


                _bookService.Add(book);

            }

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
            _bookService.Edit(book);
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

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _bookService.GetBookById(id);
            _bookService.Delete(book.Id);

            return RedirectToAction(nameof(Index));
        }


    }
}
