using Bookstore.Data;
using Bookstore.Entities;
using Bookstore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _dataContext;

        public AuthorRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public void AddAuthor(Author author)
        {
            _dataContext.Authors.Add(author);
            _dataContext.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            Author author = GetAuthorById(id);
            _dataContext.Authors.Remove(author);
            _dataContext.SaveChanges();
        }

        public void EditAuthor(Author author)
        {
            _dataContext.Authors.Update(author);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            var allAuthors = _dataContext.Authors.AsEnumerable();
            return allAuthors;
        }

        public Author GetAuthorById(int id)
        {
            var authorById = _dataContext.Authors.FirstOrDefault(author => author.Id == id);
            return authorById;
        }
    }
}
