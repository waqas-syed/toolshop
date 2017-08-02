using System.Collections.Generic;
using ToolShop.Model.Models;

namespace ToolShop.Services.Services
{
    /// <summary>
    /// Performs operations related to the Product entities
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Save the given Product
        /// </summary>
        /// <param name="product"></param>
        void SaveProduct(Product product);

        /// <summary>
        /// Update the given Product
        /// </summary>
        void UpdateProduct(Product product);

        /// <summary>
        /// Delete the given Product
        /// </summary>
        void Delete(Product product);

        /// <summary>
        /// Get the Product by the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product GetProductById(int id);

        /// <summary>
        /// Get all the Product in the database
        /// </summary>
        /// <returns></returns>
        IList<Product> GetAllProducts();

        /// <summary>
        /// Gets Products by their name and the category name provided
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        IList<Product> GetProductsByNameAndCategoryName(string productName, string categoryName);

        /// <summary>
        /// Get Products by their name and category Id
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        IList<Product> GetProductsByNameAndCategoryId(string productName, int categoryId);
    }
}
