using Bookstore.Entities;
using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            this._publisherService = publisherService;
        }

        public IActionResult Index()
        {
            var publishers = _publisherService.GetAllPublishers();
            return View(publishers);
        }

        [HttpPost]

        public JsonResult CreatePublisherAJAX(Publisher publisher)
        {
            if (publisher != null)
            {
                if (!string.IsNullOrEmpty(publisher.Name) && !string.IsNullOrWhiteSpace(publisher.Name))
                {
                    _publisherService.Add(publisher);
                }

            }

            return Json(publisher);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Publisher publisher)
        {
            if (publisher != null)
            {
                if (!string.IsNullOrEmpty(publisher.Name) && !string.IsNullOrWhiteSpace(publisher.Name))
                {
                    _publisherService.Add(publisher);
                }

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var publisher = _publisherService.GetPublisherById(id);
            return View(publisher);
        }

        [HttpPost]
        public IActionResult Edit(Publisher publisher)
        {
            _publisherService.Edit(publisher);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var publisher = _publisherService.GetPublisherById(id);
            return View(publisher);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var publisher = _publisherService.GetPublisherById(id);
            return View(publisher);
        }

        [HttpPost]
        public IActionResult Delete(Publisher publisher)
        {
            _publisherService.Delete(publisher.Id);

            return RedirectToAction(nameof(Index));
        }
    }
}
