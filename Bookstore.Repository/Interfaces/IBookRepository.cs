using Bookstore.Entities;
using Bookstore.Entities.Quotes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Repository.Interfaces
{
    public interface IBookRepository
    {
        void AddBook(Book book);

        void EditBook(Book book);

        void EditBook(int id);

        void DeleteBook(int id);
        void DeleteBook(Book book);

        Book GetBookById(int id);

        IEnumerable<Book> GetAllBooks();

        IEnumerable<Book> GetAllBooksWithFullRelationalData();

        void AddQuote(QuoteMap quote);
    }
}
