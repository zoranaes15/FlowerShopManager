using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class EditProductForm : Form
    {
        private readonly IProductService _productService;
        private Product _product;
        public EditProductForm(Product product)
        {
            InitializeComponent();
            _productService = new ProductService();
            _product = product;
            nameTextbox.Text = _product.Name;
            DescriptionTextBox.Text = _product.Description;
            stockNumericUpDown.Value = _product.Stock;
            priceNumericUpDown.Value = (decimal)_product.Price;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Product updatedProduct = new Product(
                _product.Id,
                nameTextbox.Text,
                DescriptionTextBox.Text,
                (int)stockNumericUpDown.Value,
                (double)priceNumericUpDown.Value
            );
            _productService.Update(updatedProduct);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
