using Bookstore.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        void Delete(Book cook);

        Book GetBookById(int id);

        IEnumerable<Book> GetAllBooks();

        (List<SelectListItem> Categories, List<SelectListItem> Authors, List<SelectListItem> Publishers) FillDropdowns(IEnumerable<Category> categories,
            IEnumerable<Author> authors,
            IEnumerable<Publisher> publishers);

    }
}
