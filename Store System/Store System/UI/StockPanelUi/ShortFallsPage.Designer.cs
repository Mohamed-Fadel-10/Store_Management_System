namespace Store_System.UI
{
    partial class ShortFallsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortFallsPage));
            pictureBox2 = new PictureBox();
            searchStockLbl = new Label();
            searchShortageBox = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            ShortsCount = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(457, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // searchStockLbl
            // 
            searchStockLbl.Anchor = AnchorStyles.None;
            searchStockLbl.AutoSize = true;
            searchStockLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchStockLbl.ForeColor = Color.White;
            searchStockLbl.Location = new Point(356, 33);
            searchStockLbl.Name = "searchStockLbl";
            searchStockLbl.Size = new Size(95, 23);
            searchStockLbl.TabIndex = 42;
            searchStockLbl.Text = "ابحث بالاسم";
            // 
            // searchShortageBox
            // 
            searchShortageBox.Anchor = AnchorStyles.None;
            searchShortageBox.BackColor = Color.FromArgb(24, 30, 46);
            searchShortageBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            searchShortageBox.ForeColor = Color.White;
            searchShortageBox.Location = new Point(73, 50);
            searchShortageBox.Name = "searchShortageBox";
            searchShortageBox.RightToLeft = RightToLeft.Yes;
            searchShortageBox.Size = new Size(378, 43);
            searchShortageBox.TabIndex = 41;
            searchShortageBox.TextChanged += searchShortageBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1384, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1174, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 60);
            panel1.TabIndex = 40;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(15, 6);
            label1.Name = "label1";
            label1.Size = new Size(185, 38);
            label1.TabIndex = 0;
            label1.Text = "جدول النواقص";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(27, 156, 133);
            panel3.Enabled = false;
            panel3.Location = new Point(0, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(1501, 38);
            panel3.TabIndex = 134;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(901, 45);
            label2.Name = "label2";
            label2.Size = new Size(267, 32);
            label2.TabIndex = 135;
            label2.Text = ":إجمالى عدد النواقص      ";
            // 
            // ShortsCount
            // 
            ShortsCount.Anchor = AnchorStyles.None;
            ShortsCount.AutoSize = true;
            ShortsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ShortsCount.ForeColor = Color.White;
            ShortsCount.Location = new Point(833, 53);
            ShortsCount.Name = "ShortsCount";
            ShortsCount.Size = new Size(20, 23);
            ShortsCount.TabIndex = 136;
            ShortsCount.Text = "0";
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
            Items.Location = new Point(9, 167);
            Items.Name = "Items";
            Items.ReadOnly = true;
            Items.RightToLeft = RightToLeft.Yes;
            Items.RowHeadersWidth = 51;
            Items.RowTemplate.Height = 29;
            Items.Size = new Size(1478, 753);
            Items.TabIndex = 137;
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
            // ShortFallsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(Items);
            Controls.Add(ShortsCount);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(searchStockLbl);
            Controls.Add(searchShortageBox);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MinimumSize = new Size(1496, 949);
            Name = "ShortFallsPage";
            Size = new Size(1496, 949);
            Load += ShortFallsPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label searchStockLbl;
        private TextBox searchShortageBox;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label label2;
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
        public Label ShortsCount;
        public DataGridView Items;
    }
}
