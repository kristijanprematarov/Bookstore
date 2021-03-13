using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Service.Interfaces
{
    public interface IBookService
    {
        void Add(Book book);

        void Edit(Book book);

        void Edit(int id);

        void Delete(int id);

        Book GetBookById(int id);

        IEnumerable<Book> GetAllBooks();
    }
}
