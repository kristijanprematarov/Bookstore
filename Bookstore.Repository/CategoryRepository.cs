using Bookstore.Data;
using Bookstore.Entities;
using Bookstore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bookstore.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _dataContext;

        public CategoryRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public void AddCategory(Category category)
        {
            _dataContext.Categories.Add(category);
            _dataContext.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            Category category = GetCategoryById(id);
            _dataContext.Categories.Remove(category);
            _dataContext.SaveChanges();
        }

        public void EditCategory(Category category)
        {
            _dataContext.Categories.Update(category);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var allCategories = _dataContext.Categories.AsEnumerable();
            return allCategories;
        }

        public Category GetCategoryById(int id)
        {
            var categoryById = _dataContext.Categories.FirstOrDefault(category => category.Id == id);
            return categoryById;
        }
    }
}
