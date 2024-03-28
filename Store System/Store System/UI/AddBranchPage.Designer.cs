namespace Store_System.UI
{
    partial class AddBranchPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBranchPage));
            branchNameBox = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            branchNameLbl = new Label();
            addBranchBtn = new Button();
            label2 = new Label();
            branchPhoneBox = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // branchNameBox
            // 
            branchNameBox.Anchor = AnchorStyles.None;
            branchNameBox.BackColor = Color.FromArgb(24, 30, 46);
            branchNameBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            branchNameBox.ForeColor = Color.White;
            branchNameBox.Location = new Point(472, 211);
            branchNameBox.Name = "branchNameBox";
            branchNameBox.RightToLeft = RightToLeft.Yes;
            branchNameBox.Size = new Size(293, 43);
            branchNameBox.TabIndex = 64;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(24, 30, 46);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(775, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(92, 85);
            panel2.TabIndex = 85;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(601, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 77);
            panel1.TabIndex = 84;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(148, 41);
            label1.TabIndex = 0;
            label1.Text = "إضافة فرع";
            // 
            // branchNameLbl
            // 
            branchNameLbl.Anchor = AnchorStyles.None;
            branchNameLbl.AutoSize = true;
            branchNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            branchNameLbl.ForeColor = Color.White;
            branchNameLbl.Location = new Point(674, 193);
            branchNameLbl.Name = "branchNameLbl";
            branchNameLbl.Size = new Size(79, 23);
            branchNameLbl.TabIndex = 86;
            branchNameLbl.Text = "اسم الفرع";
            // 
            // addBranchBtn
            // 
            addBranchBtn.Anchor = AnchorStyles.None;
            addBranchBtn.BackColor = Color.LimeGreen;
            addBranchBtn.FlatStyle = FlatStyle.Flat;
            addBranchBtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            addBranchBtn.ForeColor = Color.White;
            addBranchBtn.Location = new Point(314, 321);
            addBranchBtn.Name = "addBranchBtn";
            addBranchBtn.Size = new Size(234, 51);
            addBranchBtn.TabIndex = 87;
            addBranchBtn.Text = "إضافة";
            addBranchBtn.UseVisualStyleBackColor = false;
            addBranchBtn.Click += addBranchBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(302, 193);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 89;
            label2.Text = "رقم الموبايل";
            // 
            // branchPhoneBox
            // 
            branchPhoneBox.Anchor = AnchorStyles.None;
            branchPhoneBox.BackColor = Color.FromArgb(24, 30, 46);
            branchPhoneBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            branchPhoneBox.ForeColor = Color.White;
            branchPhoneBox.Location = new Point(112, 211);
            branchPhoneBox.Name = "branchPhoneBox";
            branchPhoneBox.RightToLeft = RightToLeft.Yes;
            branchPhoneBox.Size = new Size(293, 43);
            branchPhoneBox.TabIndex = 88;
            // 
            // AddBranchPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            ClientSize = new Size(889, 577);
            Controls.Add(label2);
            Controls.Add(branchPhoneBox);
            Controls.Add(addBranchBtn);
            Controls.Add(branchNameLbl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(branchNameBox);
            Name = "AddBranchPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBranchPage";
            FormClosed += AddBranchPage_FormClosed;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox branchNameBox;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label branchNameLbl;
        private Button addBranchBtn;
        private Label label2;
        private TextBox branchPhoneBox;
    }
}