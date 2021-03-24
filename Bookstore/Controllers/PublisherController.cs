﻿using Bookstore.Entities;
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
            _publisherService.Add(publisher);
            return Json(publisher);
        }
    }
}
