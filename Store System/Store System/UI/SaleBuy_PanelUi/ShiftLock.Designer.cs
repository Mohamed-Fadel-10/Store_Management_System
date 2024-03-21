namespace Store_System.UI.ControlPanelUi
{
    partial class ShiftLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftLock));
            panel1 = new Panel();
            label1 = new Label();
            label11 = new Label();
            ExpensesBox = new TextBox();
            label10 = new Label();
            shiftMoneyBox = new TextBox();
            Addbtn = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            finalShiftMoneyBox = new TextBox();
            userIDBox = new TextBox();
            branchIdBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1205, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 77);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(162, 38);
            label1.TabIndex = 0;
            label1.Text = "تقفيل شيفت";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(1040, 204);
            label11.Name = "label11";
            label11.Size = new Size(154, 23);
            label11.TabIndex = 64;
            label11.Text = "إجمالي خزنة الشيفت";
            // 
            // ExpensesBox
            // 
            ExpensesBox.Anchor = AnchorStyles.None;
            ExpensesBox.BackColor = Color.FromArgb(24, 30, 46);
            ExpensesBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ExpensesBox.ForeColor = Color.White;
            ExpensesBox.Location = new Point(587, 223);
            ExpensesBox.Name = "ExpensesBox";
            ExpensesBox.RightToLeft = RightToLeft.Yes;
            ExpensesBox.Size = new Size(277, 43);
            ExpensesBox.TabIndex = 65;
            ExpensesBox.TextChanged += ExpensesBox_TextChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(772, 204);
            label10.Name = "label10";
            label10.Size = new Size(80, 23);
            label10.TabIndex = 62;
            label10.Text = "مصروفات";
            // 
            // shiftMoneyBox
            // 
            shiftMoneyBox.Anchor = AnchorStyles.None;
            shiftMoneyBox.BackColor = Color.FromArgb(24, 30, 46);
            shiftMoneyBox.Enabled = false;
            shiftMoneyBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            shiftMoneyBox.ForeColor = Color.White;
            shiftMoneyBox.Location = new Point(910, 223);
            shiftMoneyBox.Name = "shiftMoneyBox";
            shiftMoneyBox.RightToLeft = RightToLeft.Yes;
            shiftMoneyBox.Size = new Size(293, 43);
            shiftMoneyBox.TabIndex = 63;
            shiftMoneyBox.TextChanged += shiftMoneyBox_TextChanged;
            // 
            // Addbtn
            // 
            Addbtn.Anchor = AnchorStyles.None;
            Addbtn.BackColor = Color.LimeGreen;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(569, 366);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(304, 51);
            Addbtn.TabIndex = 82;
            Addbtn.Text = "تقفيل الشيفت";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(24, 30, 46);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1383, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(92, 85);
            panel2.TabIndex = 83;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(419, 204);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 84;
            label2.Text = "صافي الشيفت";
            // 
            // finalShiftMoneyBox
            // 
            finalShiftMoneyBox.Anchor = AnchorStyles.None;
            finalShiftMoneyBox.BackColor = Color.FromArgb(24, 30, 46);
            finalShiftMoneyBox.Enabled = false;
            finalShiftMoneyBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            finalShiftMoneyBox.ForeColor = Color.White;
            finalShiftMoneyBox.Location = new Point(264, 223);
            finalShiftMoneyBox.Name = "finalShiftMoneyBox";
            finalShiftMoneyBox.RightToLeft = RightToLeft.Yes;
            finalShiftMoneyBox.Size = new Size(277, 43);
            finalShiftMoneyBox.TabIndex = 85;
            // 
            // userIDBox
            // 
            userIDBox.Anchor = AnchorStyles.None;
            userIDBox.BackColor = Color.FromArgb(24, 30, 46);
            userIDBox.Enabled = false;
            userIDBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            userIDBox.ForeColor = Color.White;
            userIDBox.Location = new Point(951, 74);
            userIDBox.Name = "userIDBox";
            userIDBox.RightToLeft = RightToLeft.Yes;
            userIDBox.Size = new Size(153, 43);
            userIDBox.TabIndex = 86;
            userIDBox.Visible = false;
            // 
            // branchIdBox
            // 
            branchIdBox.Anchor = AnchorStyles.None;
            branchIdBox.BackColor = Color.FromArgb(24, 30, 46);
            branchIdBox.Enabled = false;
            branchIdBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            branchIdBox.ForeColor = Color.White;
            branchIdBox.Location = new Point(762, 74);
            branchIdBox.Name = "branchIdBox";
            branchIdBox.RightToLeft = RightToLeft.Yes;
            branchIdBox.Size = new Size(153, 43);
            branchIdBox.TabIndex = 87;
            branchIdBox.Visible = false;
            // 
            // ShiftLock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(branchIdBox);
            Controls.Add(userIDBox);
            Controls.Add(label2);
            Controls.Add(finalShiftMoneyBox);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(Addbtn);
            Controls.Add(label11);
            Controls.Add(ExpensesBox);
            Controls.Add(shiftMoneyBox);
            Controls.Add(panel1);
            MinimumSize = new Size(1496, 949);
            Name = "ShiftLock";
            Size = new Size(1496, 949);
            Load += ShiftLock_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label11;
        private TextBox ExpensesBox;
        private Label label10;
        private Button Addbtn;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox finalShiftMoneyBox;
        public TextBox userIDBox;
        private TextBox shiftMoneyBox;
        public TextBox branchIdBox;
    }
}
