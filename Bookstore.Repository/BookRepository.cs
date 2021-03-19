using Bookstore.Data;
using Bookstore.Entities;
using Bookstore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _dataContext;

        public BookRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public void AddBook(Book book)
        {
            _dataContext.Books.Add(book);
            _dataContext.SaveChanges();
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

        public Book GetBookById(int id)
        {
            var bookById = _dataContext.Books.FirstOrDefault(book => book.Id == id);
            return bookById;
        }
    }
}
