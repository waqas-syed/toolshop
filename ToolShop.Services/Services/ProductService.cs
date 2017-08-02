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
    /// Performs operations related to Product
    /// </summary>
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// Takes in the ProductRepository and UnitOfWork to commit changes to the database
        /// </summary>
        /// <param name="productRepository"></param>
        /// <param name="unitOfWork"></param>
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public void SaveProduct(Product product)
        {
            _productRepository.Add(product);
            _unitOfWork.Commit();
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
            _unitOfWork.Commit();
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
            _unitOfWork.Commit();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IList<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public IList<Product> GetProductsByNameAndCategoryName(string productName, string categoryName)
        {
            return _productRepository.GetProductByNameAndCategoryName(productName, categoryName);
        }

        public IList<Product> GetProductsByNameAndCategoryId(string productName, int categoryId)
        {
            return _productRepository.GetProductByNameAndCategoryId(productName, categoryId);
        }
    } 
}
