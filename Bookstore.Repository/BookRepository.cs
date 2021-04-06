using Bookstore.Data;
using Bookstore.Entities;
using Bookstore.Entities.Logger;
using Bookstore.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<BookRepository> _logger;

        public BookRepository(DataContext dataContext, ILogger<BookRepository> logger)
        {
            this._dataContext = dataContext;
            this._logger = logger;
        }

        public void AddBook(Book book)
        {
            try
            {
                _dataContext.Books.Add(book);
                _dataContext.SaveChanges();
                _logger.LogInformation(LoggerMessageDisplay.BookCreated);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.BookCreated + " | " + ex);
                throw;
            }
        }

        public void DeleteBook(int id)
        {
            Book book = GetBookById(id);
            _dataContext.Books.Remove(book);
            _dataContext.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            _dataContext.Books.Remove(book);
            _dataContext.SaveChanges();
        }

        public void EditBook(Book book)
        {
            _dataContext.Books.Update(book);
            _dataContext.SaveChanges();
        }

        public void EditBook(int id)
        {
            var book = GetBookById(id);
            _dataContext.Books.Update(book);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var allBooks = _dataContext.Books.AsEnumerable();
            return allBooks;
        }

        public IEnumerable<Book> GetAllBooksWithFullRelationalData()
        {
            var result = _dataContext.Books.Include(a => a.Author).Include(c => c.Category).Include(p => p.Publisher);

            return result;
        }

        public Book GetBookById(int id)
        {
            var bookById = _dataContext.Books.FirstOrDefault(book => book.Id == id);
            return bookById;
        }
    }
}
