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
using System.Xml.Linq;

namespace ForterroAnasIdrissiCodeChallenge
{
    public partial class AddEditForm : Form
    {

        private readonly IProductService _productService;
        private readonly Product _productToEdit;

        public AddEditForm(IProductService productService, Product productToEdit = null)
        {
            InitializeComponent();
            _productService = productService;
            _productToEdit = productToEdit;
            configureNumericControls();

            if (_productToEdit != null)
            {
                Text = "Edit Product";
                PopulateForm();
            }
            else
            {
                Text = "Add New Product";
            }
        }

        private void PopulateForm()
        {
            AEProductNameTextBox.Text = _productToEdit.Name;
            AEProductCategoryTextBox.Text = _productToEdit.Category;
            AEProductUnitPriceNum.Value = _productToEdit.UnitPrice;
            AEProductQuatityNum.Value = _productToEdit.StockQuantity;
            AEProductDescriptionTextBox.Text = _productToEdit.Description;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(AEProductNameTextBox.Text))
            {
                MessageBox.Show("Product name is required.", "Validation Error");
                return false;
            }

            if (AEProductUnitPriceNum.Value <= 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation Error");
                return false;
            }

            if (AEProductQuatityNum.Value < 0)
            {
                MessageBox.Show("Quantity cannot be negative.", "Validation Error");
                return false;
            }

            return true;
        }

        private void AEProductSaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var product = new Product(
                AEProductNameTextBox.Text,
                AEProductDescriptionTextBox.Text,
                AEProductUnitPriceNum.Value,
                (int)AEProductQuatityNum.Value,
                AEProductCategoryTextBox.Text);

            if (_productToEdit == null)
            {
                _productService.AddProduct(product);
            }
            //else
            //{
            //    _productService.UpdateProduct(product);
            //}

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AEProductCancelButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void configureNumericControls()
        {
            AEProductUnitPriceNum.DecimalPlaces = 2;
            AEProductUnitPriceNum.Minimum = 0;
            AEProductUnitPriceNum.Maximum = 999999;
            AEProductUnitPriceNum.Increment = 0.01m;
            AEProductUnitPriceNum.Value = 0.00m;  // Default value

            // Quantity control (integer)
            AEProductQuatityNum.DecimalPlaces = 0;
            AEProductQuatityNum.Minimum = 0;
            AEProductQuatityNum.Maximum = 1000;
            AEProductQuatityNum.Increment = 1;
            AEProductQuatityNum.Value = 0;
        }
    }
}
