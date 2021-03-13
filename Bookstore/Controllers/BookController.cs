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

        public BookController(IBookService bookService)
        {
            this._bookService = bookService;
        }
        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();

            return View(books);
        }


        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> Categories = new List<SelectListItem>()
            {
                new SelectListItem()  {Text="Romance",Value = "1", Selected = true},
                new SelectListItem()  {Text="Drama",Value = "2"},
                new SelectListItem()  {Text="Adventure",Value = "3"}
            };

            List<SelectListItem> Authors = new List<SelectListItem>()
            {
                new SelectListItem() {Text="Agatha Christie",Value="1", Selected = true},
                new SelectListItem() {Text="Stephen King",Value="2"},
                new SelectListItem() {Text="William Shakespeare",Value="3"}
            };

            List<SelectListItem> Publishers = new List<SelectListItem>()
            {
                new SelectListItem() {Text="William Morrow Paperbacks",Value="1", Selected = true},
                new SelectListItem() {Text="Scholastic",Value="2"},
                new SelectListItem() {Text="Penguin Random House",Value="3"}
            };


            ViewBag.CategoryList = Categories;
            ViewBag.AuthorList = Authors;
            ViewBag.PublisherList = Publishers;

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
            List<SelectListItem> Categories = new List<SelectListItem>()
            {
                new SelectListItem()  {Text="Romance",Value = "1", Selected = true},
                new SelectListItem()  {Text="Drama",Value = "2"},
                new SelectListItem()  {Text="Adventure",Value = "3"}
            };

            List<SelectListItem> Authors = new List<SelectListItem>()
            {
                new SelectListItem() {Text="Agatha Christie",Value="1", Selected = true},
                new SelectListItem() {Text="Stephen King",Value="2"},
                new SelectListItem() {Text="William Shakespeare",Value="3"}
            };

            List<SelectListItem> Publishers = new List<SelectListItem>()
            {
                new SelectListItem() {Text="William Morrow Paperbacks",Value="1", Selected = true},
                new SelectListItem() {Text="Scholastic",Value="2"},
                new SelectListItem() {Text="Penguin Random House",Value="3"}
            };

            ViewBag.CategoryList = Categories;
            ViewBag.AuthorList = Authors;
            ViewBag.PublisherList = Publishers;

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
