namespace Store_System.UI.UiReportsUserControls
{
    partial class SaleingReports
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DaySale = new Button();
            MonthSale = new Button();
            FaturaSale = new Button();
            YearSale = new Button();
            panel1 = new Panel();
            label1 = new Label();
            orderNumber = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DaySale
            // 
            DaySale.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            DaySale.Location = new Point(1005, 159);
            DaySale.Name = "DaySale";
            DaySale.Size = new Size(302, 240);
            DaySale.TabIndex = 0;
            DaySale.Text = "مبيعات اليوم";
            DaySale.UseVisualStyleBackColor = true;
            DaySale.Click += DaySale_Click;
            // 
            // MonthSale
            // 
            MonthSale.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            MonthSale.Location = new Point(255, 159);
            MonthSale.Name = "MonthSale";
            MonthSale.Size = new Size(302, 240);
            MonthSale.TabIndex = 1;
            MonthSale.Text = "مبيعات اخر شهر";
            MonthSale.UseVisualStyleBackColor = true;
            MonthSale.Click += MonthSale_Click;
            // 
            // FaturaSale
            // 
            FaturaSale.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            FaturaSale.Location = new Point(255, 462);
            FaturaSale.Name = "FaturaSale";
            FaturaSale.Size = new Size(302, 240);
            FaturaSale.TabIndex = 2;
            FaturaSale.Text = "فاتورة بيع محددة";
            FaturaSale.UseVisualStyleBackColor = true;
            FaturaSale.Click += FaturaSale_Click;
            // 
            // YearSale
            // 
            YearSale.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            YearSale.Location = new Point(1005, 462);
            YearSale.Name = "YearSale";
            YearSale.Size = new Size(302, 240);
            YearSale.TabIndex = 3;
            YearSale.Text = "مبيعات سنة";
            YearSale.UseVisualStyleBackColor = true;
            YearSale.Click += YearSale_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1191, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 68);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(87, 13);
            label1.Name = "label1";
            label1.Size = new Size(173, 38);
            label1.TabIndex = 0;
            label1.Text = "تقارير مبيعات";
            // 
            // orderNumber
            // 
            orderNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderNumber.Location = new Point(563, 492);
            orderNumber.Name = "orderNumber";
            orderNumber.Size = new Size(191, 34);
            orderNumber.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(567, 461);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 31;
            label2.Text = "أدخل رقم الفاتورة";
            // 
            // SaleingReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(label2);
            Controls.Add(orderNumber);
            Controls.Add(panel1);
            Controls.Add(YearSale);
            Controls.Add(FaturaSale);
            Controls.Add(MonthSale);
            Controls.Add(DaySale);
            MaximumSize = new Size(1496, 949);
            MinimumSize = new Size(1496, 949);
            Name = "SaleingReports";
            Size = new Size(1496, 949);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DaySale;
        private Button MonthSale;
        private Button FaturaSale;
        private Button YearSale;
        private Panel panel1;
        private Label label1;
        private TextBox orderNumber;
        private Label label2;
    }
}
