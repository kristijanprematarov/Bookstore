using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Repository.Interfaces
{
    public interface IAuthorRepository
    {
        void AddAuthor(Author author);

        void EditAuthor(Author author);

        void DeleteAuthor(int id);

        Author GetAuthorById(int id);

        IEnumerable<Author> GetAllAuthors();
    }
}
