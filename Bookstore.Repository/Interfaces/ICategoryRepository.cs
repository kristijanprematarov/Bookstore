using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);

        void EditCategory(Category category);

        void DeleteCategory(int id);

        Category GetCategoryById(int id);

        IEnumerable<Category> GetAllCategories();
    }
}
