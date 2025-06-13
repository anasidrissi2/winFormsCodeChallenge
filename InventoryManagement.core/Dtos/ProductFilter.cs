using InventoryManagement.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.core.Dtos
{
    public class ProductFilter : IProductFilter
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int minStockQuantity { get; set; }
        public int maxStockQuantity { get; set; }
        public int minUnitPrice { get; set; }
        public int maxUnitPrice { get; set; }


        public int UnitPriceMin => throw new NotImplementedException();

        public int UnitPriceMax => throw new NotImplementedException();

        public int StockQuanityMin => throw new NotImplementedException();

        public int StockQuantityMax => throw new NotImplementedException();
    }


}
