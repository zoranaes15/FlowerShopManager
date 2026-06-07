namespace UI
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            FromdateTimePicker1 = new DateTimePicker();
            TodateTimePicker2 = new DateTimePicker();
            Fromlabel1 = new Label();
            Tolabel2 = new Label();
            dataGridView1 = new DataGridView();
            generateSalesButton = new Button();
            generateLowStockButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            Fromlabel1.AutoSize = true;
            Fromlabel1.Location = new System.Drawing.Point(20, 20);
            Fromlabel1.Text = "From:";
            Fromlabel1.Name = "Fromlabel1";

            FromdateTimePicker1.Location = new System.Drawing.Point(80, 16);
            FromdateTimePicker1.Size = new System.Drawing.Size(200, 27);
            FromdateTimePicker1.Name = "FromdateTimePicker1";

            Tolabel2.AutoSize = true;
            Tolabel2.Location = new System.Drawing.Point(300, 20);
            Tolabel2.Text = "To:";
            Tolabel2.Name = "Tolabel2";

            TodateTimePicker2.Location = new System.Drawing.Point(340, 16);
            TodateTimePicker2.Size = new System.Drawing.Size(200, 27);
            TodateTimePicker2.Name = "TodateTimePicker2";

            generateSalesButton.Location = new System.Drawing.Point(560, 14);
            generateSalesButton.Size = new System.Drawing.Size(130, 30);
            generateSalesButton.Text = "Generate Sales Report";
            generateSalesButton.Name = "generateSalesButton";
            generateSalesButton.UseVisualStyleBackColor = true;
            generateSalesButton.Click += GenerateSalesButton_Click;

            generateLowStockButton.Location = new System.Drawing.Point(706, 14);
            generateLowStockButton.Size = new System.Drawing.Size(150, 30);
            generateLowStockButton.Text = "Generate Low Stock Report";
            generateLowStockButton.Name = "generateLowStockButton";
            generateLowStockButton.UseVisualStyleBackColor = true;
            generateLowStockButton.Click += GenerateLowStockButton_Click;

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(20, 60);
            dataGridView1.Size = new System.Drawing.Size(836, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(875, 380);
            Controls.Add(dataGridView1);
            Controls.Add(Tolabel2);
            Controls.Add(Fromlabel1);
            Controls.Add(TodateTimePicker2);
            Controls.Add(FromdateTimePicker1);
            Controls.Add(generateSalesButton);
            Controls.Add(generateLowStockButton);
            Name = "ReportForm";
            Text = "Reports";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DateTimePicker FromdateTimePicker1;
        private DateTimePicker TodateTimePicker2;
        private Label Fromlabel1;
        private Label Tolabel2;
        private DataGridView dataGridView1;
        private Button generateSalesButton;
        private Button generateLowStockButton;
    }
}
