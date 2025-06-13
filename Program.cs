using InventoryManagement.core.Interfaces;
using InventoryManagement.core.Models;
using InventoryManagement.core.Repositories;
using InventoryManagement.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForterroAnasIdrissiCodeChallenge
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IProductRepository productRepository = new InMemoryProductRepository();
            IProductService productService = new ProductService(productRepository);

            loadSampleData(productService);


            Application.Run(new MainForm(productService));
        }

        private static void loadSampleData(IProductService productService)
        {
            productService.AddProduct(new Product("Laptop", "High performance laptop", 999.99m, 10, "Electronics"));
            productService.AddProduct(new Product("Mouse", "Wireless mouse", 19.99m, 50, "Electronics"));
            productService.AddProduct(new Product("Keyboard", "Mechanical keyboard", 89.99m, 30, "Electronics"));
            productService.AddProduct(new Product("Monitor", "27-inch 4K monitor", 399.99m, 15, "Electronics"));
            productService.AddProduct(new Product("Smartphone", "Latest model with OLED display", 799.99m, 25, "Electronics"));
            productService.AddProduct(new Product("Headphones", "Noise-cancelling over-ear headphones", 149.99m, 40, "Electronics"));
            productService.AddProduct(new Product("Desk", "Office desk", 199.99m, 20, "Furniture"));
            productService.AddProduct(new Product("Chair", "Ergonomic office chair", 129.99m, 35, "Furniture"));
            productService.AddProduct(new Product("Bookshelf", "5-tier wooden bookshelf", 89.99m, 12, "Furniture"));
            productService.AddProduct(new Product("Notebook", "A4 ruled notebook", 2.99m, 200, "Office Supplies"));
            productService.AddProduct(new Product("Pen Pack", "Pack of 10 blue pens", 4.99m, 150, "Office Supplies"));
            productService.AddProduct(new Product("Stapler", "Standard size stapler", 8.99m, 60, "Office Supplies"));
            productService.AddProduct(new Product("Blender", "500W kitchen blender", 59.99m, 18, "Kitchen"));
            productService.AddProduct(new Product("Toaster", "2-slice toaster", 29.99m, 25, "Kitchen"));
            productService.AddProduct(new Product("Cookware Set", "Non-stick pots and pans", 99.99m, 10, "Kitchen"));
            productService.AddProduct(new Product("Tent", "4-person camping tent", 149.99m, 8, "Outdoor"));
            productService.AddProduct(new Product("Cooler", "50-quart rolling cooler", 79.99m, 14, "Outdoor"));
            productService.AddProduct(new Product("Flashlight", "LED rechargeable flashlight", 19.99m, 60, "Outdoor"));
            productService.AddProduct(new Product("Gift Card", "Generic store gift card", 50.00m, 100, "Miscellaneous"));
        }


    }
}
