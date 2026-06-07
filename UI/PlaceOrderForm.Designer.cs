namespace UI
{
    partial class PlaceOrderForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            productsGridView = new DataGridView();
            basketGridView = new DataGridView();
            addToBasketButton = new Button();
            placeOrderButton = new Button();
            productsLabel = new Label();
            basketLabel = new Label();
            totalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)basketGridView).BeginInit();
            SuspendLayout();

            productsLabel.AutoSize = true;
            productsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            productsLabel.Location = new System.Drawing.Point(12, 10);
            productsLabel.Text = "Available Products";
            productsLabel.Name = "productsLabel";

            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new System.Drawing.Point(12, 35);
            productsGridView.Size = new System.Drawing.Size(400, 300);
            productsGridView.Name = "productsGridView";
            productsGridView.RowHeadersWidth = 51;
            productsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGridView.MultiSelect = false;

            addToBasketButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            addToBasketButton.Location = new System.Drawing.Point(430, 160);
            addToBasketButton.Size = new System.Drawing.Size(120, 32);
            addToBasketButton.Text = "Add to Basket →";
            addToBasketButton.Name = "addToBasketButton";
            addToBasketButton.UseVisualStyleBackColor = true;
            addToBasketButton.Click += AddToBasketButton_Click;

            basketLabel.AutoSize = true;
            basketLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            basketLabel.Location = new System.Drawing.Point(570, 10);
            basketLabel.Text = "Basket";
            basketLabel.Name = "basketLabel";

            basketGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            basketGridView.Location = new System.Drawing.Point(570, 35);
            basketGridView.Size = new System.Drawing.Size(400, 250);
            basketGridView.Name = "basketGridView";
            basketGridView.RowHeadersWidth = 51;
            basketGridView.AllowUserToAddRows = false;

            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            totalLabel.Location = new System.Drawing.Point(570, 300);
            totalLabel.Text = "Total: $0.00";
            totalLabel.Name = "totalLabel";

            placeOrderButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            placeOrderButton.Location = new System.Drawing.Point(700, 335);
            placeOrderButton.Size = new System.Drawing.Size(130, 32);
            placeOrderButton.Text = "Place Order";
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Click += PlaceOrderButton_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(990, 390);
            Controls.Add(productsLabel);
            Controls.Add(productsGridView);
            Controls.Add(addToBasketButton);
            Controls.Add(basketLabel);
            Controls.Add(basketGridView);
            Controls.Add(totalLabel);
            Controls.Add(placeOrderButton);
            Name = "PlaceOrderForm";
            Text = "Place Order";
            Load += PlaceOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)basketGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView productsGridView;
        private DataGridView basketGridView;
        private Button addToBasketButton;
        private Button placeOrderButton;
        private Label productsLabel;
        private Label basketLabel;
        private Label totalLabel;
    }
}
