using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Repository.Interfaces
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        
        void EditBook(Book book);

        void DeleteBook(int id);

        Book GetBookById(int id);

        IEnumerable<Book> GetAllBooks();
    }
}
