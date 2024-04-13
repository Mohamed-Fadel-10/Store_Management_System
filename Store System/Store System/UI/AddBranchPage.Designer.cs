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
            addressBox = new TextBox();
            label3 = new Label();
            Items = new DataGridView();
            _Name = new DataGridViewTextBoxColumn();
            _Phone = new DataGridViewTextBoxColumn();
            _Address = new DataGridViewTextBoxColumn();
            label4 = new Label();
            SumMoney = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            SuspendLayout();
            // 
            // branchNameBox
            // 
            branchNameBox.Anchor = AnchorStyles.None;
            branchNameBox.BackColor = Color.FromArgb(24, 30, 46);
            branchNameBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            branchNameBox.ForeColor = Color.White;
            branchNameBox.Location = new Point(578, 108);
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
            panel2.Location = new Point(192, 0);
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
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(597, 4);
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
            branchNameLbl.Location = new Point(780, 90);
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
            addBranchBtn.Location = new Point(12, 344);
            addBranchBtn.Name = "addBranchBtn";
            addBranchBtn.Size = new Size(195, 51);
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
            label2.Location = new Point(454, 90);
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
            branchPhoneBox.Location = new Point(264, 108);
            branchPhoneBox.Name = "branchPhoneBox";
            branchPhoneBox.RightToLeft = RightToLeft.Yes;
            branchPhoneBox.Size = new Size(293, 43);
            branchPhoneBox.TabIndex = 88;
            // 
            // addressBox
            // 
            addressBox.Anchor = AnchorStyles.None;
            addressBox.BackColor = Color.FromArgb(24, 30, 46);
            addressBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addressBox.ForeColor = Color.White;
            addressBox.Location = new Point(578, 175);
            addressBox.Name = "addressBox";
            addressBox.RightToLeft = RightToLeft.Yes;
            addressBox.Size = new Size(293, 43);
            addressBox.TabIndex = 90;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(808, 160);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 91;
            label3.Text = "العنوان";
            // 
            // Items
            // 
            Items.Anchor = AnchorStyles.None;
            Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Items.BackgroundColor = Color.Snow;
            Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items.Columns.AddRange(new DataGridViewColumn[] { _Name, _Phone, _Address });
            Items.Location = new Point(12, 401);
            Items.Name = "Items";
            Items.RightToLeft = RightToLeft.Yes;
            Items.RowHeadersWidth = 51;
            Items.RowTemplate.Height = 29;
            Items.Size = new Size(864, 248);
            Items.TabIndex = 92;
            Items.RowHeaderMouseClick += Items_RowHeaderMouseClick;
            // 
            // _Name
            // 
            _Name.HeaderText = "إسم الفرع";
            _Name.MinimumWidth = 6;
            _Name.Name = "_Name";
            // 
            // _Phone
            // 
            _Phone.HeaderText = "رقم الموبايل";
            _Phone.MinimumWidth = 6;
            _Phone.Name = "_Phone";
            // 
            // _Address
            // 
            _Address.HeaderText = "العنوان";
            _Address.MinimumWidth = 6;
            _Address.Name = "_Address";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(733, 245);
            label4.Name = "label4";
            label4.Size = new Size(135, 23);
            label4.TabIndex = 94;
            label4.Text = "إجمالى خزنة الفرع";
            // 
            // SumMoney
            // 
            SumMoney.Anchor = AnchorStyles.None;
            SumMoney.AutoSize = true;
            SumMoney.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SumMoney.ForeColor = Color.White;
            SumMoney.Location = new Point(622, 245);
            SumMoney.Name = "SumMoney";
            SumMoney.Size = new Size(20, 23);
            SumMoney.TabIndex = 95;
            SumMoney.Text = "0";
            // 
            // AddBranchPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            ClientSize = new Size(889, 674);
            Controls.Add(SumMoney);
            Controls.Add(label4);
            Controls.Add(Items);
            Controls.Add(label3);
            Controls.Add(addressBox);
            Controls.Add(label2);
            Controls.Add(branchPhoneBox);
            Controls.Add(addBranchBtn);
            Controls.Add(branchNameLbl);
            Controls.Add(panel1);
            Controls.Add(branchNameBox);
            Name = "AddBranchPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBranchPage";
            FormClosed += AddBranchPage_FormClosed;
            Load += AddBranchPage_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
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
        private TextBox addressBox;
        private Label label3;
        private DataGridView Items;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn _Phone;
        private DataGridViewTextBoxColumn _Address;
        private Label label4;
        private Label SumMoney;
    }
}