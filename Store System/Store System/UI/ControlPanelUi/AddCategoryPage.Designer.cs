namespace Store_System.UI
{
    partial class AddCategoryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryPage));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            catDiscriptionLbl = new Label();
            catNameLbl = new Label();
            catNameBox = new TextBox();
            categoryCodeLbl = new Label();
            categoryCodeBox = new TextBox();
            catDescriptionBox = new TextBox();
            AddCatBtn = new Button();
            existCategoriesGridView = new DataGridView();
            _name = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            Discription = new DataGridViewTextBoxColumn();
            usersPic = new PictureBox();
            panel5 = new Panel();
            existUserLbl = new Label();
            pictureBox2 = new PictureBox();
            searchCatLbl = new Label();
            searchCatBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)existCategoriesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersPic).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1098, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 68);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(17, 11);
            label1.Name = "label1";
            label1.Size = new Size(221, 38);
            label1.TabIndex = 0;
            label1.Text = "إضافة صنف جديد";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1360, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // catDiscriptionLbl
            // 
            catDiscriptionLbl.Anchor = AnchorStyles.None;
            catDiscriptionLbl.AutoSize = true;
            catDiscriptionLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            catDiscriptionLbl.ForeColor = Color.White;
            catDiscriptionLbl.Location = new Point(521, 189);
            catDiscriptionLbl.Name = "catDiscriptionLbl";
            catDiscriptionLbl.Size = new Size(53, 23);
            catDiscriptionLbl.TabIndex = 19;
            catDiscriptionLbl.Text = "وصف";
            // 
            // catNameLbl
            // 
            catNameLbl.Anchor = AnchorStyles.None;
            catNameLbl.AutoSize = true;
            catNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            catNameLbl.ForeColor = Color.White;
            catNameLbl.Location = new Point(981, 189);
            catNameLbl.Name = "catNameLbl";
            catNameLbl.Size = new Size(93, 23);
            catNameLbl.TabIndex = 18;
            catNameLbl.Text = "اسم الصنف";
            // 
            // catNameBox
            // 
            catNameBox.Anchor = AnchorStyles.None;
            catNameBox.BackColor = Color.FromArgb(24, 30, 46);
            catNameBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            catNameBox.ForeColor = Color.White;
            catNameBox.Location = new Point(625, 207);
            catNameBox.Name = "catNameBox";
            catNameBox.RightToLeft = RightToLeft.Yes;
            catNameBox.Size = new Size(449, 47);
            catNameBox.TabIndex = 16;
            // 
            // categoryCodeLbl
            // 
            categoryCodeLbl.Anchor = AnchorStyles.None;
            categoryCodeLbl.AutoSize = true;
            categoryCodeLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            categoryCodeLbl.ForeColor = Color.White;
            categoryCodeLbl.Location = new Point(1306, 189);
            categoryCodeLbl.Name = "categoryCodeLbl";
            categoryCodeLbl.Size = new Size(92, 23);
            categoryCodeLbl.TabIndex = 14;
            categoryCodeLbl.Text = "كود الصنف";
            // 
            // categoryCodeBox
            // 
            categoryCodeBox.Anchor = AnchorStyles.None;
            categoryCodeBox.BackColor = Color.FromArgb(24, 30, 46);
            categoryCodeBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            categoryCodeBox.ForeColor = Color.White;
            categoryCodeBox.Location = new Point(1111, 207);
            categoryCodeBox.Name = "categoryCodeBox";
            categoryCodeBox.RightToLeft = RightToLeft.Yes;
            categoryCodeBox.Size = new Size(296, 47);
            categoryCodeBox.TabIndex = 15;
            // 
            // catDescriptionBox
            // 
            catDescriptionBox.Anchor = AnchorStyles.None;
            catDescriptionBox.BackColor = Color.FromArgb(24, 30, 46);
            catDescriptionBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            catDescriptionBox.ForeColor = Color.White;
            catDescriptionBox.Location = new Point(79, 207);
            catDescriptionBox.Multiline = true;
            catDescriptionBox.Name = "catDescriptionBox";
            catDescriptionBox.RightToLeft = RightToLeft.Yes;
            catDescriptionBox.Size = new Size(502, 47);
            catDescriptionBox.TabIndex = 17;
            // 
            // AddCatBtn
            // 
            AddCatBtn.Anchor = AnchorStyles.None;
            AddCatBtn.BackColor = Color.LimeGreen;
            AddCatBtn.FlatStyle = FlatStyle.Flat;
            AddCatBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddCatBtn.ForeColor = Color.White;
            AddCatBtn.Location = new Point(725, 345);
            AddCatBtn.Name = "AddCatBtn";
            AddCatBtn.Size = new Size(125, 47);
            AddCatBtn.TabIndex = 20;
            AddCatBtn.Text = "إضافة";
            AddCatBtn.UseVisualStyleBackColor = false;
            AddCatBtn.Click += AddCatBtn_Click;
            // 
            // existCategoriesGridView
            // 
            existCategoriesGridView.Anchor = AnchorStyles.None;
            existCategoriesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            existCategoriesGridView.BackgroundColor = Color.Snow;
            existCategoriesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            existCategoriesGridView.Columns.AddRange(new DataGridViewColumn[] { _name, Code, Discription });
            existCategoriesGridView.Location = new Point(79, 432);
            existCategoriesGridView.Name = "existCategoriesGridView";
            existCategoriesGridView.RightToLeft = RightToLeft.Yes;
            existCategoriesGridView.RowHeadersWidth = 51;
            existCategoriesGridView.RowTemplate.Height = 29;
            existCategoriesGridView.Size = new Size(1330, 489);
            existCategoriesGridView.TabIndex = 21;
            existCategoriesGridView.RowHeaderMouseClick += existCategoriesGridView_RowHeaderMouseClick;
            // 
            // _name
            // 
            _name.HeaderText = "إسم الصنف";
            _name.MinimumWidth = 6;
            _name.Name = "_name";
            // 
            // Code
            // 
            Code.HeaderText = "كود التصنيف";
            Code.MinimumWidth = 6;
            Code.Name = "Code";
            // 
            // Discription
            // 
            Discription.HeaderText = "ملاحظات";
            Discription.MinimumWidth = 6;
            Discription.Name = "Discription";
            // 
            // usersPic
            // 
            usersPic.Anchor = AnchorStyles.None;
            usersPic.BackColor = Color.FromArgb(24, 30, 46);
            usersPic.Image = (Image)resources.GetObject("usersPic.Image");
            usersPic.Location = new Point(1348, 352);
            usersPic.Name = "usersPic";
            usersPic.Size = new Size(62, 57);
            usersPic.SizeMode = PictureBoxSizeMode.Zoom;
            usersPic.TabIndex = 23;
            usersPic.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(27, 156, 133);
            panel5.Controls.Add(existUserLbl);
            panel5.Location = new Point(1129, 352);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 57);
            panel5.TabIndex = 22;
            // 
            // existUserLbl
            // 
            existUserLbl.Anchor = AnchorStyles.None;
            existUserLbl.AutoSize = true;
            existUserLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            existUserLbl.ForeColor = Color.Snow;
            existUserLbl.Location = new Point(13, 9);
            existUserLbl.Name = "existUserLbl";
            existUserLbl.Size = new Size(188, 31);
            existUserLbl.TabIndex = 0;
            existUserLbl.Text = "الأصناف الموجودة";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(465, 371);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // searchCatLbl
            // 
            searchCatLbl.Anchor = AnchorStyles.None;
            searchCatLbl.AutoSize = true;
            searchCatLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchCatLbl.ForeColor = Color.White;
            searchCatLbl.Location = new Point(364, 352);
            searchCatLbl.Name = "searchCatLbl";
            searchCatLbl.Size = new Size(95, 23);
            searchCatLbl.TabIndex = 25;
            searchCatLbl.Text = "ابحث بالاسم";
            // 
            // searchCatBox
            // 
            searchCatBox.Anchor = AnchorStyles.None;
            searchCatBox.BackColor = Color.FromArgb(24, 30, 46);
            searchCatBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            searchCatBox.ForeColor = Color.White;
            searchCatBox.Location = new Point(79, 371);
            searchCatBox.Name = "searchCatBox";
            searchCatBox.RightToLeft = RightToLeft.Yes;
            searchCatBox.Size = new Size(380, 38);
            searchCatBox.TabIndex = 24;
            searchCatBox.TextChanged += searchCatBox_TextChanged;
            // 
            // AddCategoryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(pictureBox2);
            Controls.Add(searchCatLbl);
            Controls.Add(searchCatBox);
            Controls.Add(usersPic);
            Controls.Add(panel5);
            Controls.Add(existCategoriesGridView);
            Controls.Add(AddCatBtn);
            Controls.Add(catDiscriptionLbl);
            Controls.Add(catNameLbl);
            Controls.Add(catNameBox);
            Controls.Add(categoryCodeLbl);
            Controls.Add(categoryCodeBox);
            Controls.Add(catDescriptionBox);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(1496, 949);
            Name = "AddCategoryPage";
            Size = new Size(1496, 949);
            Load += AddCategoryPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)existCategoriesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersPic).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label catDiscriptionLbl;
        private Label catNameLbl;
        private TextBox catNameBox;
        private Label categoryCodeLbl;
        private TextBox categoryCodeBox;
        private TextBox catDescriptionBox;
        private Button AddCatBtn;
        private DataGridView existCategoriesGridView;
        private PictureBox usersPic;
        private Panel panel5;
        private Label existUserLbl;
        private PictureBox pictureBox2;
        private Label searchCatLbl;
        private TextBox searchCatBox;
        private DataGridViewTextBoxColumn _name;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Discription;
    }
}
