namespace Store_System.UI.UiReportsUserControls
{
    partial class BuyReports
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
            panel1 = new Panel();
            label1 = new Label();
            YearBuy = new Button();
            FaturaBuy = new Button();
            MonthBuy = new Button();
            DayBuy = new Button();
            label2 = new Label();
            orderNumber = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1176, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 68);
            panel1.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(72, 15);
            label1.Name = "label1";
            label1.Size = new Size(194, 38);
            label1.TabIndex = 0;
            label1.Text = "تقارير مشتريات";
            // 
            // YearBuy
            // 
            YearBuy.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            YearBuy.Location = new Point(977, 481);
            YearBuy.Name = "YearBuy";
            YearBuy.Size = new Size(347, 240);
            YearBuy.TabIndex = 35;
            YearBuy.Text = "مشتريات اخر سنة";
            YearBuy.UseVisualStyleBackColor = true;
            YearBuy.Click += YearBuy_Click;
            // 
            // FaturaBuy
            // 
            FaturaBuy.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            FaturaBuy.Location = new Point(247, 481);
            FaturaBuy.Name = "FaturaBuy";
            FaturaBuy.Size = new Size(347, 240);
            FaturaBuy.TabIndex = 34;
            FaturaBuy.Text = "فاتورة شراء محددة";
            FaturaBuy.UseVisualStyleBackColor = true;
            FaturaBuy.Click += FaturaBuy_Click;
            // 
            // MonthBuy
            // 
            MonthBuy.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            MonthBuy.Location = new Point(247, 178);
            MonthBuy.Name = "MonthBuy";
            MonthBuy.Size = new Size(347, 240);
            MonthBuy.TabIndex = 33;
            MonthBuy.Text = "مشتريات اخر شهر";
            MonthBuy.UseVisualStyleBackColor = true;
            MonthBuy.Click += MonthBuy_Click;
            // 
            // DayBuy
            // 
            DayBuy.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            DayBuy.Location = new Point(977, 178);
            DayBuy.Name = "DayBuy";
            DayBuy.Size = new Size(347, 240);
            DayBuy.TabIndex = 32;
            DayBuy.Text = "مشتريات اليوم";
            DayBuy.UseVisualStyleBackColor = true;
            DayBuy.Click += DayBuy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(444, 441);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 38;
            label2.Text = "أدخل رقم الفاتورة";
            // 
            // orderNumber
            // 
            orderNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderNumber.Location = new Point(247, 441);
            orderNumber.Name = "orderNumber";
            orderNumber.Size = new Size(191, 34);
            orderNumber.TabIndex = 37;
            // 
            // BuyReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(panel1);
            Controls.Add(YearBuy);
            Controls.Add(FaturaBuy);
            Controls.Add(MonthBuy);
            Controls.Add(DayBuy);
            Controls.Add(label2);
            Controls.Add(orderNumber);
            MaximumSize = new Size(1496, 949);
            MinimumSize = new Size(1496, 949);
            Name = "BuyReports";
            Size = new Size(1496, 949);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button YearBuy;
        private Button FaturaBuy;
        private Button MonthBuy;
        private Button DayBuy;
        private Label label2;
        private TextBox orderNumber;
    }
}
