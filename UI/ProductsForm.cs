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
    public partial class ProductsForm : Form
    {
        private readonly User _user;
        private readonly IProductService _productService;

        private DataTable productsTable;

        public ProductsForm(User user)
        {
            InitializeComponent();
            productsGridView.RowHeadersVisible = false;
            productsGridView.AllowUserToAddRows = false;
            this.Load += ProductsForm_Load;
            _user = user;
            _productService = new ProductService();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

            productsTable = new DataTable("Products");

            var btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "Change";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Name = "EditCol";

            var btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Name = "DeleteCol";

            productsGridView.DataSource = null;
            productsGridView.Columns.Clear();

            productsTable.Columns.Add("Id", typeof(int));
            productsTable.Columns.Add("Name", typeof(string));
            productsTable.Columns.Add("Description", typeof(string));
            productsTable.Columns.Add("Price", typeof(double));
            productsTable.Columns.Add("Stock", typeof(int));

            List<Product> products = _productService.GetAll();

            foreach (var product in products)
            {
                productsTable.Rows.Add(product.Id, product.Name, product.Description, product.Price, product.Stock);
            }

            productsGridView.DataSource = productsTable;
            productsGridView.Columns.Add(btnEdit);
            productsGridView.Columns.Add(btnDelete);
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (productsGridView.Columns[e.ColumnIndex].Name == "DeleteCol")
            {
                if (_user.Role != UserRole.Admin)
                {
                    MessageBox.Show("Only admins can delete product.");
                    return;
                }
                var selectedRow = productsGridView.Rows[e.RowIndex];
                object? targetValue = selectedRow.Cells["Id"].Value;

                int id = Convert.ToInt32(targetValue);

                _productService.Delete(id);
                ProductsForm_Load(this, EventArgs.Empty);
            }
            else if (productsGridView.Columns[e.ColumnIndex].Name == "EditCol")
            {
                if (_user.Role != UserRole.Admin)
                {
                    MessageBox.Show("Only admins can edit product.");
                    return;
                }
                var selectedRow = productsGridView.Rows[e.RowIndex];
                object? targetValue = selectedRow.Cells["Id"].Value;

                int id = Convert.ToInt32(targetValue);
                Product product = _productService.GetById(id);

                EditProductForm editProductForm = new EditProductForm(product);
                if (editProductForm.ShowDialog() == DialogResult.OK)
                {
                    ProductsForm_Load(this, EventArgs.Empty);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_user.Role != UserRole.Admin)
            {
                MessageBox.Show("Only admins can add products.");
                return;
            }
            AddProductForm addProductForm = new AddProductForm();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                ProductsForm_Load(this, EventArgs.Empty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
