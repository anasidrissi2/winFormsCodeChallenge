using InventoryManagement.core.Interfaces;
using InventoryManagement.core.Models;
using InventoryManagement.core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForterroAnasIdrissiCodeChallenge
{
    public partial class MainForm : Form
    {

        private readonly IProductService _productService;
        private BindingSource _productsBindingSource = new BindingSource();
        public MainForm(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            _productsBindingSource = new BindingSource();
            SetupProductsDataGridView();
            Loadproducts();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SetupProductsDataGridView()
        {

            // clear data
            productsListingDataGridView.Columns.Clear();


            productsListingDataGridView.AutoGenerateColumns = false;
            productsListingDataGridView.DataSource = _productsBindingSource;

            // Configure columns
            productsListingDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Product Name"
            });

            productsListingDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Product Category"
            });

            productsListingDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description"
            });

            productsListingDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "Unit Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            productsListingDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StockQuantity",
                HeaderText = "Stock Quantity"
            });

        }

        private void Loadproducts()
        {
            var products = _productService.GetAllProducts().ToList();

            // Reset the BindingSource
            _productsBindingSource.DataSource = typeof(Product);
            _productsBindingSource.DataSource = products;

            productsListingDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

    }
}
