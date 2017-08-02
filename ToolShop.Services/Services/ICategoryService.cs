using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop.Model.Models;

namespace ToolShop.Services.Services
{
    /// <summary>
    /// Performs operations related to the Category entity
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// Save the given category
        /// </summary>
        /// <param name="category"></param>
        void SaveCategory(Category category);

        /// <summary>
        /// Update the given Category
        /// </summary>
        void UpdateCategory(Category category);

        /// <summary>
        /// Delete the given Category
        /// </summary>
        void Delete(Category category);

        /// <summary>
        /// Get the category by the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Category GetCategoryById(int id);

        /// <summary>
        /// Get all the Categories in the database
        /// </summary>
        /// <returns></returns>
        IList<Category> GetAllCategories(string name = null);
    }
}
