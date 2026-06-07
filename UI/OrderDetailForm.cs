using Application.Domain;
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
    public partial class OrderDetailForm : Form
    {
        private readonly Order _order;
        private DataTable orderItemsTable;
        public OrderDetailForm(Order order)
        {
            InitializeComponent();
            _order = order;
            orderItemsGridView.RowHeadersVisible = false;
            orderItemsGridView.AllowUserToAddRows = false;
            label1.Text = $"Customer: {_order.Customer.FirstName} {_order.Customer.LastName}";
            label2.Text = $"Date: {_order.OrderDate}";
            label3.Text = $"Total: {_order.TotalAmount}";
            label4.Text = $"Status: {_order.Status}";
        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {

            orderItemsTable = new DataTable("Products");

            orderItemsGridView.DataSource = null;
            orderItemsGridView.Columns.Clear();

            orderItemsTable.Columns.Add("Id", typeof(int));
            orderItemsTable.Columns.Add("Name", typeof(string));
            orderItemsTable.Columns.Add("Description", typeof(string));
            orderItemsTable.Columns.Add("Price per piece", typeof(double));
            orderItemsTable.Columns.Add("Quantity", typeof(int));
            orderItemsTable.Columns.Add("Total", typeof(double));


            foreach (var odrededItem in _order.Items)
            {
                orderItemsTable.Rows.Add(
                    odrededItem.Product.Id, 
                    odrededItem.Product.Name, 
                    odrededItem.Product.Description, 
                    odrededItem.UnitPrice, 
                    odrededItem.Quantity, 
                    odrededItem.UnitPrice * odrededItem.Quantity);
            }

            orderItemsGridView.DataSource = orderItemsTable;
            orderItemsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
