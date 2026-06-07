namespace UI
{
    partial class ProductsForm
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
            button1 = new Button();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            SuspendLayout();
            // 
            // productsGridView
            // 
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(14, 67);
            productsGridView.Margin = new Padding(3, 4, 3, 4);
            productsGridView.Name = "productsGridView";
            productsGridView.RowHeadersWidth = 51;
            productsGridView.Size = new Size(752, 267);
            productsGridView.TabIndex = 1;
            productsGridView.CellContentClick += productsGridView_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(674, 17);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(571, 17);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(91, 35);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 357);
            Controls.Add(AddButton);
            Controls.Add(button1);
            Controls.Add(productsGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductsForm";
            Text = "Products";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            ResumeLayout(false);
        }
        private DataGridView productsGridView;
        private Button button1;
        private Button AddButton;
    }
}
