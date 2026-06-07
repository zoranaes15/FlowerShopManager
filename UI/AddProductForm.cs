using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;


namespace UI
{
    public partial class AddProductForm : Form
    {
        private readonly IProductService _productService;
        public AddProductForm()
        {
            InitializeComponent();
            _productService = new ProductService();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextbox.Text;
            string description = DescriptionTextBox.Text;
            int stock = (int)stockNumericUpDown.Value;
            double price = (double)priceNumericUpDown.Value;
            Product product = new Product(name, description, stock, price);
            _productService.Create(product);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
