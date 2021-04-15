using Bookstore.Entities.Quotes;
using Bookstore.Models;
using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;

        public HomeController(ILogger<HomeController> logger, IBookService bookService)
        {
            this._logger = logger;
            this._bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            var booksWithFullData = _bookService.GetAllBooksWithFullRelationalData();

            var homeViewModel = new HomeViewModel()
            {
                AllBooksList = books
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public async Task<JsonResult> GetQuotes()
        {
            QuotesData quotesData = new QuotesData();

            using (var httpClient = new HttpClient())
            {
                using (var request = await httpClient.GetAsync("https://opinionated-quotes-api.gigalixirapp.com/v1/quotes"))
                {
                    string apiResponse = await request.Content.ReadAsStringAsync();

                    quotesData = JsonConvert.DeserializeObject<QuotesData>(apiResponse);
                }

                //Whenever we want more quotes uncomment the following foreach

                //foreach (var quote in quotesData.Quotes)
                //{
                //    string tagsString = string.Join(",", quote.Tags.ToArray());
                //    QuoteMap quoteMap = new QuoteMap
                //    {
                //        Tags = tagsString,
                //        Quote = quote.quote,
                //        Language = quote.lang,
                //        Author = quote.Author
                //    };

                //    _bookService.AddQuote(quoteMap);
                //}
            }

            return Json(quotesData);
        }

    }
}
