namespace Store_System.UI.UiReportsUserControls
{
    partial class gain_loss_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gain_loss_Control));
            panel1 = new Panel();
            label1 = new Label();
            ToDate = new DateTimePicker();
            FromDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            gain = new Label();
            gainPrecentage = new Label();
            TotalBuying = new Label();
            TotalSaleing = new Label();
            reportbtn = new Button();
            DayReport = new Button();
            MonthReport = new Button();
            YearReport = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1148, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 68);
            panel1.TabIndex = 37;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(18, 13);
            label1.Name = "label1";
            label1.Size = new Size(212, 38);
            label1.TabIndex = 0;
            label1.Text = "تقرير ربح وخسارة";
            // 
            // ToDate
            // 
            ToDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ToDate.Format = DateTimePickerFormat.Short;
            ToDate.Location = new Point(290, 250);
            ToDate.Name = "ToDate";
            ToDate.RightToLeft = RightToLeft.Yes;
            ToDate.Size = new Size(250, 36);
            ToDate.TabIndex = 39;
            // 
            // FromDate
            // 
            FromDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            FromDate.Format = DateTimePickerFormat.Short;
            FromDate.Location = new Point(290, 208);
            FromDate.Name = "FromDate";
            FromDate.RightToLeft = RightToLeft.Yes;
            FromDate.Size = new Size(250, 36);
            FromDate.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(549, 205);
            label2.Name = "label2";
            label2.Size = new Size(41, 30);
            label2.TabIndex = 41;
            label2.Text = "من";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(546, 250);
            label3.Name = "label3";
            label3.Size = new Size(44, 30);
            label3.TabIndex = 42;
            label3.Text = "الى";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1108, 414);
            label4.Name = "label4";
            label4.Size = new Size(202, 38);
            label4.TabIndex = 43;
            label4.Text = "إجمالى المبيعات";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1078, 495);
            label5.Name = "label5";
            label5.Size = new Size(232, 38);
            label5.TabIndex = 44;
            label5.Text = "إجمالى المصروفات";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1240, 576);
            label6.Name = "label6";
            label6.Size = new Size(70, 38);
            label6.TabIndex = 45;
            label6.Text = "الربح";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1097, 657);
            label7.Name = "label7";
            label7.Size = new Size(213, 38);
            label7.TabIndex = 46;
            label7.Text = "صافى نسبة الربح";
            // 
            // gain
            // 
            gain.AutoSize = true;
            gain.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            gain.ForeColor = Color.White;
            gain.Location = new Point(960, 579);
            gain.Name = "gain";
            gain.Size = new Size(33, 38);
            gain.TabIndex = 47;
            gain.Text = "0";
            // 
            // gainPrecentage
            // 
            gainPrecentage.AutoSize = true;
            gainPrecentage.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            gainPrecentage.ForeColor = Color.White;
            gainPrecentage.Location = new Point(954, 657);
            gainPrecentage.Name = "gainPrecentage";
            gainPrecentage.Size = new Size(41, 38);
            gainPrecentage.TabIndex = 48;
            gainPrecentage.Text = "%";
            // 
            // TotalBuying
            // 
            TotalBuying.AutoSize = true;
            TotalBuying.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            TotalBuying.ForeColor = Color.White;
            TotalBuying.Location = new Point(960, 498);
            TotalBuying.Name = "TotalBuying";
            TotalBuying.Size = new Size(33, 38);
            TotalBuying.TabIndex = 49;
            TotalBuying.Text = "0";
            // 
            // TotalSaleing
            // 
            TotalSaleing.AutoSize = true;
            TotalSaleing.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            TotalSaleing.ForeColor = Color.White;
            TotalSaleing.Location = new Point(960, 414);
            TotalSaleing.Name = "TotalSaleing";
            TotalSaleing.Size = new Size(33, 38);
            TotalSaleing.TabIndex = 50;
            TotalSaleing.Text = "0";
            // 
            // reportbtn
            // 
            reportbtn.BackColor = Color.FromArgb(27, 156, 133);
            reportbtn.FlatStyle = FlatStyle.Flat;
            reportbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reportbtn.ForeColor = SystemColors.ButtonHighlight;
            reportbtn.Location = new Point(48, 208);
            reportbtn.Name = "reportbtn";
            reportbtn.Size = new Size(199, 81);
            reportbtn.TabIndex = 51;
            reportbtn.Text = "تقرير فترة";
            reportbtn.UseVisualStyleBackColor = false;
            reportbtn.Click += reportbtn_Click;
            // 
            // DayReport
            // 
            DayReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DayReport.Location = new Point(1239, 205);
            DayReport.Name = "DayReport";
            DayReport.Size = new Size(199, 81);
            DayReport.TabIndex = 52;
            DayReport.Text = "تقرير يومى";
            DayReport.UseVisualStyleBackColor = true;
            DayReport.Click += DayReport_Click;
            // 
            // MonthReport
            // 
            MonthReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MonthReport.Location = new Point(955, 205);
            MonthReport.Name = "MonthReport";
            MonthReport.Size = new Size(199, 81);
            MonthReport.TabIndex = 53;
            MonthReport.Text = "تقرير شهرى";
            MonthReport.UseVisualStyleBackColor = true;
            MonthReport.Click += MonthReport_Click;
            // 
            // YearReport
            // 
            YearReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            YearReport.Location = new Point(671, 205);
            YearReport.Name = "YearReport";
            YearReport.Size = new Size(199, 81);
            YearReport.TabIndex = 54;
            YearReport.Text = "تقرير سنوى";
            YearReport.UseVisualStyleBackColor = true;
            YearReport.Click += YearReport_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1389, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // gain_loss_Control
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(pictureBox1);
            Controls.Add(YearReport);
            Controls.Add(MonthReport);
            Controls.Add(DayReport);
            Controls.Add(reportbtn);
            Controls.Add(TotalSaleing);
            Controls.Add(TotalBuying);
            Controls.Add(gainPrecentage);
            Controls.Add(gain);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FromDate);
            Controls.Add(ToDate);
            Controls.Add(panel1);
            MaximumSize = new Size(1496, 949);
            MinimumSize = new Size(1496, 949);
            Name = "gain_loss_Control";
            Size = new Size(1496, 949);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker ToDate;
        private DateTimePicker FromDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label gain;
        private Label gainPrecentage;
        private Label TotalBuying;
        private Label TotalSaleing;
        private Button reportbtn;
        private Button DayReport;
        private Button MonthReport;
        private Button YearReport;
        private PictureBox pictureBox1;
    }
}
