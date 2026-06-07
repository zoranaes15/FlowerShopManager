namespace UI
{
    partial class OrderDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            orderItemsGridView = new DataGridView();
            closeButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).BeginInit();
            SuspendLayout();

            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.TabIndex = 6;
            label1.Text = "label1";

            label2.AutoSize = true;
            label2.Location = new Point(185, 14);
            label2.Name = "label2";
            label2.TabIndex = 7;
            label2.Text = "label2";

            label3.AutoSize = true;
            label3.Location = new Point(370, 14);
            label3.Name = "label3";
            label3.TabIndex = 8;
            label3.Text = "label3";

            label4.AutoSize = true;
            label4.Location = new Point(520, 14);
            label4.Name = "label4";
            label4.TabIndex = 9;
            label4.Text = "label4";

            orderItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderItemsGridView.Location = new Point(12, 42);
            orderItemsGridView.Name = "orderItemsGridView";
            orderItemsGridView.RowHeadersWidth = 51;
            orderItemsGridView.Size = new Size(660, 270);
            orderItemsGridView.TabIndex = 4;

            closeButton.Location = new Point(590, 325);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(82, 30);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 370);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeButton);
            Controls.Add(orderItemsGridView);
            Name = "OrderDetailForm";
            Text = "Order Details";
            Load += OrderDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView orderItemsGridView;
        private Button closeButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
