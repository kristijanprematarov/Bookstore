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
            return View();
        }

        public IActionResult Create()
        {
            List<SelectListItem> Categories = new List<SelectListItem>()
            {
                new SelectListItem()  {Text="Romance",Value = "1"},
                new SelectListItem()  {Text="Drama",Value = "2"},
                new SelectListItem()  {Text="Adventure",Value = "3"}
            };

            ViewBag.CategoryList = Categories;
            return View();
        }

        public IActionResult Edit()
        {
            List<SelectListItem> Categories = new List<SelectListItem>()
            {
                new SelectListItem()  {Text="Romance",Value = "1"},
                new SelectListItem()  {Text="Drama",Value = "2"},
                new SelectListItem()  {Text="Adventure",Value = "3"}
            };

            ViewBag.CategoryList = Categories;
            return View();
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
