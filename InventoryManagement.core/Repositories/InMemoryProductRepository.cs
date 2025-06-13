using InventoryManagement.core.Interfaces;
using InventoryManagement.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.core.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {

        private readonly List<Product> _products;
        private int _nextId = 1;

        public void Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null) { 
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.UnitPrice = product.UnitPrice;
                existingProduct.StockQuantity = product.StockQuantity;
                existingProduct.CreatedDate = product.CreatedDate;
            }
        }


        public Product FindOneById(int productId)
        {
            Product selectedProduct = _products.FirstOrDefault(p=>p.Id == productId);
            return selectedProduct;
        }

        public void Delete(int productId)
        {
            _products.RemoveAll(p=>p.Id==productId);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products.AsReadOnly();
        }


        public IEnumerable<Product> FindByName(string name)
        {
            var result = _products.Where(p => p.Name.ToLower().Contains(name.ToLower()));
            return result;
        }


    }
}
