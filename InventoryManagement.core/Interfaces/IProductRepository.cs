using InventoryManagement.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.core.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product FindOneById(int productId);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> FindByName(string name);
    }
}
