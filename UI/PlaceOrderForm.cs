using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;
using System.Data;

namespace UI
{
    public partial class PlaceOrderForm : Form
    {
        private readonly User _customer;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;
        private readonly INotificationService _notificationService;

        private List<Product> _products = new();

        private class BasketItem
        {
            public Product Product { get; set; } = null!;
            public int Quantity { get; set; }
            public double UnitPrice { get; set; }
        }

        private List<BasketItem> _basket = new();

        public PlaceOrderForm(User customer)
        {
            InitializeComponent();
            _customer = customer;
            _productService = new ProductService();
            _orderService = new OrderService();
            _orderItemService = new OrderItemService();
            _notificationService = new NotificationService();
        }

        private void PlaceOrderForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            RefreshBasket();
        }

        private void LoadProducts()
        {
            _products = _productService.GetAll().Where(p => p.Stock > 0).ToList();
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Stock", typeof(int));
            foreach (var p in _products)
                dt.Rows.Add(p.Id, p.Name, p.Price, p.Stock);
            productsGridView.DataSource = dt;
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGridView.RowHeadersVisible = false;
            productsGridView.AllowUserToAddRows = false;
        }

        private void RefreshBasket()
        {
            var dt = new DataTable();
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Qty", typeof(int));
            dt.Columns.Add("Unit Price", typeof(double));
            dt.Columns.Add("Subtotal", typeof(double));
            foreach (var item in _basket)
                dt.Rows.Add(item.Product.Name, item.Quantity, item.UnitPrice, item.Quantity * item.UnitPrice);
            basketGridView.DataSource = dt;
            basketGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            basketGridView.RowHeadersVisible = false;
            basketGridView.AllowUserToAddRows = false;
            double total = _basket.Sum(i => i.Quantity * i.UnitPrice);
            totalLabel.Text = $"Total: ${total:F2}";
        }

        private void AddToBasketButton_Click(object sender, EventArgs e)
        {
            if (productsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int productId = Convert.ToInt32(productsGridView.SelectedRows[0].Cells["Id"].Value);
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product == null) return;

            var qtyForm = new QuantityInputForm(product.Name);
            if (qtyForm.ShowDialog() != DialogResult.OK) return;
            int qty = qtyForm.Quantity;

            var existing = _basket.FirstOrDefault(b => b.Product.Id == productId);
            if (existing != null)
                existing.Quantity += qty;
            else
                _basket.Add(new BasketItem { Product = product, Quantity = qty, UnitPrice = product.Price });

            RefreshBasket();
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_basket.Count == 0)
                    throw new Exception("Your order is empty.");

                foreach (var item in _basket)
                {
                    var freshProduct = _productService.GetById(item.Product.Id);
                    if (item.Quantity > freshProduct.Stock)
                        throw new Exception($"Insufficient stock for {item.Product.Name}.");
                }

                double total = _basket.Sum(i => i.Quantity * i.UnitPrice);
                var order = new Order(_customer, DateTime.Now, total, OrderStatus.Pending);
                _orderService.Create(order);

                foreach (var item in _basket)
                {
                    var orderItem = new OrderItem(order, item.Product, item.Quantity, item.UnitPrice);
                    _orderItemService.Create(orderItem);

                    var freshProduct = _productService.GetById(item.Product.Id);
                    var updated = new Product(freshProduct.Id, freshProduct.Name, freshProduct.Description,
                        freshProduct.Stock - item.Quantity, freshProduct.Price);
                    _productService.Update(updated);
                }

                var notification = new Notification(_customer,
                    $"Your order #{order.Id} has been received.", DateTime.Now);
                _notificationService.Create(notification);

                MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
