using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop.DataStore.Infrastructure;
using ToolShop.DataStore.Repositories;
using ToolShop.Model.Models;

namespace ToolShop.Services.Services
{
    /// <summary>
    /// Category Service
    /// </summary>
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// Accepts the CategoryRepository to perform operations in the database
        /// </summary>
        /// <param name="categoryRepository"></param>
        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Save the category
        /// </summary>
        /// <param name="category"></param>
        public void SaveCategory(Category category)
        {
            _categoryRepository.Add(category);
            _unitOfWork.Commit();
        }

        /// <summary>
        /// Update the category
        /// </summary>
        /// <param name="category"></param>
        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
            _unitOfWork.Commit();
        }

        /// <summary>
        /// Delete the category
        /// </summary>
        /// <param name="category"></param>
        public void Delete(Category category)
        {
            _categoryRepository.Update(category);
            _unitOfWork.Commit();
        }

        /// <summary>
        /// Get the category by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        /// <summary>
        /// Get all the categories
        /// </summary>
        /// <returns></returns>
        public IList<Category> GetAllCategories(string name = null)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return _categoryRepository.GetAll();
            }
            else
            {
                return _categoryRepository.GetCategoriesByName(name);
            }
        }
    }
}
