using Bookstore.Entities;
using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }

        [HttpPost]

        public JsonResult CreateCategoryAJAX(Category category)
        {
            _categoryService.Add(category);
            return Json(category);
        }
    }
}
