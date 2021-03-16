using Bookstore.Entities;
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
            var dropdowns = _bookService.FillDropdowns();

            var categories = _categoryService.GetAllCategories();
            var authors = _authorService.GetAllAuthors();
            var publishers = _publisherService.GetAllPublishers();

            ViewBag.CategoryList = dropdowns.Categories;
            ViewBag.AuthorList = dropdowns.Authors;
            ViewBag.PublisherList = dropdowns.Publishers;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Add(book);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            var dropdowns = _bookService.FillDropdowns();

            var categories = _categoryService.GetAllCategories();
            var authors = _authorService.GetAllAuthors();
            var publishers = _publisherService.GetAllPublishers();

            ViewBag.CategoryList = dropdowns.Categories;
            ViewBag.AuthorList = dropdowns.Authors;
            ViewBag.PublisherList = dropdowns.Publishers;

            var book = _bookService.GetBookById(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book, int id)
        {
            _bookService.Edit(book);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }


    }
}
