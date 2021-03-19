using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Service.Interfaces
{
    public interface ICategoryService
    {
        void Add(Category category);

        void Edit(Category category);

        void Delete(int id);
        void Delete(Category category);

        Category GetCategoryById(int id);

        IEnumerable<Category> GetAllCategories();
    }
}
