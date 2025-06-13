using InventoryManagement.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.core.Interfaces
{
    public interface IProductService
    {
        void AddProduct(Product product);

        Product GetProductById(int productId);

        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> SearchProductsByName(string productName);

    }
}
