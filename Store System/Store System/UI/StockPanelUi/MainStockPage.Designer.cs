namespace Store_System.UI
{
    partial class MainStockPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStockPage));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            searchStockLbl = new Label();
            searchStockBox = new TextBox();
            Items = new DataGridView();
            _Barcode = new DataGridViewTextBoxColumn();
            _Name = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            _Quantity = new DataGridViewTextBoxColumn();
            _cost = new DataGridViewTextBoxColumn();
            _discount = new DataGridViewTextBoxColumn();
            Sale = new DataGridViewTextBoxColumn();
            _color = new DataGridViewTextBoxColumn();
            _size = new DataGridViewTextBoxColumn();
            notes = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label2 = new Label();
            TotalStockSystem = new TextBox();
            label3 = new Label();
            AvailableProductsBox = new TextBox();
            label4 = new Label();
            ShortsCount = new TextBox();
            label7 = new Label();
            ItemChoosecomb = new ComboBox();
            label5 = new Label();
            CategoriesCombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1396, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1178, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 60);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(188, 38);
            label1.TabIndex = 0;
            label1.Text = "المخزن الرئيسي";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(481, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // searchStockLbl
            // 
            searchStockLbl.Anchor = AnchorStyles.None;
            searchStockLbl.AutoSize = true;
            searchStockLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchStockLbl.ForeColor = Color.White;
            searchStockLbl.Location = new Point(380, 22);
            searchStockLbl.Name = "searchStockLbl";
            searchStockLbl.Size = new Size(95, 23);
            searchStockLbl.TabIndex = 28;
            searchStockLbl.Text = "ابحث بالاسم";
            // 
            // searchStockBox
            // 
            searchStockBox.Anchor = AnchorStyles.None;
            searchStockBox.BackColor = Color.FromArgb(24, 30, 46);
            searchStockBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            searchStockBox.ForeColor = Color.White;
            searchStockBox.Location = new Point(27, 39);
            searchStockBox.Name = "searchStockBox";
            searchStockBox.RightToLeft = RightToLeft.Yes;
            searchStockBox.Size = new Size(448, 43);
            searchStockBox.TabIndex = 27;
            searchStockBox.TextChanged += searchStockBox_TextChanged;
            // 
            // Items
            // 
            Items.AllowUserToAddRows = false;
            Items.AllowUserToDeleteRows = false;
            Items.Anchor = AnchorStyles.None;
            Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Items.BackgroundColor = Color.Snow;
            Items.BorderStyle = BorderStyle.Fixed3D;
            Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items.Columns.AddRange(new DataGridViewColumn[] { _Barcode, _Name, category, Supplier, _Quantity, _cost, _discount, Sale, _color, _size, notes });
            Items.Location = new Point(7, 207);
            Items.Name = "Items";
            Items.ReadOnly = true;
            Items.RightToLeft = RightToLeft.Yes;
            Items.RowHeadersWidth = 51;
            Items.RowTemplate.Height = 29;
            Items.Size = new Size(1478, 654);
            Items.TabIndex = 139;
            // 
            // _Barcode
            // 
            _Barcode.HeaderText = "الكود";
            _Barcode.MinimumWidth = 6;
            _Barcode.Name = "_Barcode";
            _Barcode.ReadOnly = true;
            // 
            // _Name
            // 
            _Name.HeaderText = "إسم المنتج";
            _Name.MinimumWidth = 6;
            _Name.Name = "_Name";
            _Name.ReadOnly = true;
            // 
            // category
            // 
            category.HeaderText = "نوع الصنف";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.ReadOnly = true;
            // 
            // Supplier
            // 
            Supplier.HeaderText = "المورد";
            Supplier.MinimumWidth = 6;
            Supplier.Name = "Supplier";
            Supplier.ReadOnly = true;
            // 
            // _Quantity
            // 
            _Quantity.HeaderText = "الكمية";
            _Quantity.MinimumWidth = 6;
            _Quantity.Name = "_Quantity";
            _Quantity.ReadOnly = true;
            // 
            // _cost
            // 
            _cost.HeaderText = "سعر الشراء";
            _cost.MinimumWidth = 6;
            _cost.Name = "_cost";
            _cost.ReadOnly = true;
            // 
            // _discount
            // 
            _discount.HeaderText = "الخصم";
            _discount.MinimumWidth = 6;
            _discount.Name = "_discount";
            _discount.ReadOnly = true;
            // 
            // Sale
            // 
            Sale.HeaderText = "سعر البيع";
            Sale.MinimumWidth = 6;
            Sale.Name = "Sale";
            Sale.ReadOnly = true;
            // 
            // _color
            // 
            _color.HeaderText = "اللون";
            _color.MinimumWidth = 6;
            _color.Name = "_color";
            _color.ReadOnly = true;
            // 
            // _size
            // 
            _size.HeaderText = "المقاس";
            _size.MinimumWidth = 6;
            _size.Name = "_size";
            _size.ReadOnly = true;
            // 
            // notes
            // 
            notes.HeaderText = "ملاحظات";
            notes.MinimumWidth = 6;
            notes.Name = "notes";
            notes.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(27, 156, 133);
            panel3.Enabled = false;
            panel3.Location = new Point(-2, 189);
            panel3.Name = "panel3";
            panel3.Size = new Size(1501, 38);
            panel3.TabIndex = 138;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1383, 110);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 141;
            label2.Text = "إجمالى الخزنة";
            // 
            // TotalStockSystem
            // 
            TotalStockSystem.Anchor = AnchorStyles.None;
            TotalStockSystem.BackColor = Color.FromArgb(24, 30, 46);
            TotalStockSystem.Enabled = false;
            TotalStockSystem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TotalStockSystem.ForeColor = Color.White;
            TotalStockSystem.Location = new Point(1291, 130);
            TotalStockSystem.Name = "TotalStockSystem";
            TotalStockSystem.RightToLeft = RightToLeft.Yes;
            TotalStockSystem.Size = new Size(194, 43);
            TotalStockSystem.TabIndex = 140;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1107, 112);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 143;
            label3.Text = "عدد المنتجات المتاحة";
            // 
            // AvailableProductsBox
            // 
            AvailableProductsBox.Anchor = AnchorStyles.None;
            AvailableProductsBox.BackColor = Color.FromArgb(24, 30, 46);
            AvailableProductsBox.Enabled = false;
            AvailableProductsBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AvailableProductsBox.ForeColor = Color.White;
            AvailableProductsBox.Location = new Point(1071, 129);
            AvailableProductsBox.Name = "AvailableProductsBox";
            AvailableProductsBox.RightToLeft = RightToLeft.Yes;
            AvailableProductsBox.Size = new Size(194, 43);
            AvailableProductsBox.TabIndex = 142;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(935, 112);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 145;
            label4.Text = "نواقص المخزن";
            // 
            // ShortsCount
            // 
            ShortsCount.Anchor = AnchorStyles.None;
            ShortsCount.BackColor = Color.FromArgb(24, 30, 46);
            ShortsCount.Enabled = false;
            ShortsCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ShortsCount.ForeColor = Color.White;
            ShortsCount.Location = new Point(849, 129);
            ShortsCount.Name = "ShortsCount";
            ShortsCount.RightToLeft = RightToLeft.Yes;
            ShortsCount.Size = new Size(194, 43);
            ShortsCount.TabIndex = 144;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(702, 110);
            label7.Name = "label7";
            label7.Size = new Size(129, 23);
            label7.TabIndex = 147;
            label7.Text = "تحديد من المخزن";
            // 
            // ItemChoosecomb
            // 
            ItemChoosecomb.BackColor = Color.FromArgb(24, 30, 46);
            ItemChoosecomb.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            ItemChoosecomb.ForeColor = Color.White;
            ItemChoosecomb.FormattingEnabled = true;
            ItemChoosecomb.Items.AddRange(new object[] { "متاح", "على وشك انتهاء الكمية", "" });
            ItemChoosecomb.Location = new Point(447, 127);
            ItemChoosecomb.Name = "ItemChoosecomb";
            ItemChoosecomb.RightToLeft = RightToLeft.Yes;
            ItemChoosecomb.Size = new Size(384, 46);
            ItemChoosecomb.TabIndex = 146;
            ItemChoosecomb.SelectedIndexChanged += ItemChoosecomb_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(293, 110);
            label5.Name = "label5";
            label5.Size = new Size(137, 23);
            label5.TabIndex = 149;
            label5.Text = "تحديد صنف معين";
            // 
            // CategoriesCombo
            // 
            CategoriesCombo.BackColor = Color.FromArgb(24, 30, 46);
            CategoriesCombo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CategoriesCombo.ForeColor = Color.White;
            CategoriesCombo.FormattingEnabled = true;
            CategoriesCombo.Location = new Point(27, 127);
            CategoriesCombo.Name = "CategoriesCombo";
            CategoriesCombo.RightToLeft = RightToLeft.Yes;
            CategoriesCombo.Size = new Size(403, 43);
            CategoriesCombo.TabIndex = 148;
            CategoriesCombo.SelectedIndexChanged += CategoriesCombo_SelectedIndexChanged;
            // 
            // MainStockPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ShortsCount);
            Controls.Add(AvailableProductsBox);
            Controls.Add(label5);
            Controls.Add(CategoriesCombo);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(Items);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(searchStockLbl);
            Controls.Add(searchStockBox);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(ItemChoosecomb);
            Controls.Add(TotalStockSystem);
            MinimumSize = new Size(1496, 949);
            Name = "MainStockPage";
            Size = new Size(1496, 949);
            Load += MainStockPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label searchStockLbl;
        private TextBox searchStockBox;
        private DataGridView Items;
        private DataGridViewTextBoxColumn _Barcode;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn Supplier;
        private DataGridViewTextBoxColumn _Quantity;
        private DataGridViewTextBoxColumn _cost;
        private DataGridViewTextBoxColumn _discount;
        private DataGridViewTextBoxColumn Sale;
        private DataGridViewTextBoxColumn _color;
        private DataGridViewTextBoxColumn _size;
        private DataGridViewTextBoxColumn notes;
        private Panel panel3;
        private Label label2;
        private TextBox TotalStockSystem;
        private Label label3;
        private TextBox AvailableProductsBox;
        private Label label4;
        private TextBox ShortsCount;
        private Label label7;
        private ComboBox ItemChoosecomb;
        private Label label5;
        private ComboBox CategoriesCombo;
    }
}
