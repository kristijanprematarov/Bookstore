using Bookstore.Entities;
using Bookstore.Repository.Interfaces;
using Bookstore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            _categoryRepository.AddCategory(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }

        public void Delete(Category category)
        {
            _categoryRepository.DeleteCategory(category);
        }

        public void Edit(Category category)
        {
            _categoryRepository.EditCategory(category);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var result = _categoryRepository.GetAllCategories();
            return result;
        }

        public Category GetCategoryById(int id)
        {
            var result = _categoryRepository.GetCategoryById(id);
            return result;
        }
    }
}
