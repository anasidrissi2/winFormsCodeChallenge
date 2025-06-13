using InventoryManagement.core.Interfaces;
using InventoryManagement.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.core.Services
{
    public class ProductService : IProductService
    {


        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }



        public void AddProduct(Product product)
        {
                if (product == null) throw new ArgumentNullException(nameof(Product));
            product.CreatedDate = DateTime.Now;
            _productRepository.Add(product);
        }

        public void DeleteProduct(int productId)
        {
            _productRepository.Delete(productId);
        }

        public Product GetProductById(int productId)
        {
            return _productRepository.FindOneById(productId);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Product> SearchProductsByName(string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {
                return _productRepository.GetAll();
            }
            else
            {
                return _productRepository.FindByName(productName);
            }
        }
    }
}
