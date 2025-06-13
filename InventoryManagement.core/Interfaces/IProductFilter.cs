using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.core.Interfaces
{
    internal interface IProductFilter
    {
        string Name { get; }
        int UnitPriceMin { get; }
        int UnitPriceMax { get; }
        int StockQuanityMin { get; }
        int StockQuantityMax { get; }


    }
}
