namespace UI
{
    public partial class QuantityInputForm : Form
    {
        public int Quantity { get; private set; }

        public QuantityInputForm(string productName)
        {
            InitializeComponent();
            promptLabel.Text = $"Enter quantity for {productName}:";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if ((int)quantityNumeric.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Quantity = (int)quantityNumeric.Value;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
