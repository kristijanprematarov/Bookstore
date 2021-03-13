using Bookstore.Entities;
using Bookstore.Repository.Interfaces;
using Bookstore.Service.Interfaces;
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

        public Book GetBookById(int id)
        {
            var result = _bookRepository.GetBookById(id);
            return result;
        }
    }
}
