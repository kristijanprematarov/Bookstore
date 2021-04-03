using Bookstore.Entities;
using Bookstore.Repository.Interfaces;
using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this._bookRepository = bookRepository;
        }

        public void Add(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public void Delete(int id)
        {
            _bookRepository.DeleteBook(id);
        }

        public void Delete(Book book)
        {
            _bookRepository.DeleteBook(book);
        }

        public void Edit(Book book)
        {
            _bookRepository.EditBook(book);
        }

        public void Edit(int id)
        {
            var book = _bookRepository.GetBookById(id);
            _bookRepository.EditBook(book);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var result = _bookRepository.GetAllBooks();
            return result;
        }

        public IEnumerable<Book> GetAllBooksWithFullRelationalData()
        {
            var result = _bookRepository.GetAllBooksWithFullRelationalData();

            return result;
        }

        public Book GetBookById(int id)
        {
            var result = _bookRepository.GetBookById(id);
            return result;
        }

        // ******************* HELPER FUNCTIONS *******************

        #region Helper Functions

        public (List<SelectListItem> Categories, List<SelectListItem> Authors, List<SelectListItem> Publishers) FillDropdowns(
            IEnumerable<Category> categories,
            IEnumerable<Author> authors,
            IEnumerable<Publisher> publishers)
        {
            List<SelectListItem> Categories = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0",Text = "Select Category...", Selected = true, Disabled=true }
            };

            List<SelectListItem> Authors = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0",Text = "Select Author...", Selected = true, Disabled=true }
            };

            List<SelectListItem> Publishers = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0",Text = "Select Publisher...", Selected = true, Disabled=true }
            };

            foreach (var category in categories)
            {
                Categories.Add(new SelectListItem { Value = category.Id.ToString(), Text = category.Name });
            }

            foreach (var author in authors)
            {
                Authors.Add(new SelectListItem { Value = author.Id.ToString(), Text = author.Name });
            }

            foreach (var publisher in publishers)
            {
                Publishers.Add(new SelectListItem { Value = publisher.Id.ToString(), Text = publisher.Name });
            }

            #region OldCode_StaticValues

            //List<SelectListItem> Categories = new List<SelectListItem>()
            //{
            //    new SelectListItem()  {Text="Romance",Value = "1", Selected = true},
            //    new SelectListItem()  {Text="Drama",Value = "2"},
            //    new SelectListItem()  {Text="Adventure",Value = "3"}
            //};

            //List<SelectListItem> Authors = new List<SelectListItem>()
            //{
            //    new SelectListItem() {Text="Agatha Christie",Value="1", Selected = true},
            //    new SelectListItem() {Text="Stephen King",Value="2"},
            //    new SelectListItem() {Text="William Shakespeare",Value="3"}
            //};

            //List<SelectListItem> Publishers = new List<SelectListItem>()
            //{
            //    new SelectListItem() {Text="William Morrow Paperbacks",Value="1", Selected = true},
            //    new SelectListItem() {Text="Scholastic",Value="2"},
            //    new SelectListItem() {Text="Penguin Random House",Value="3"}
            //};

            #endregion

            return (Categories, Authors, Publishers);
        }

        #endregion

    }
}
