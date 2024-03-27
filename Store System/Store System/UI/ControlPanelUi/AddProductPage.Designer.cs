namespace Store_System.UI
{
    partial class AddProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductPage));
            barCodeLbl = new Label();
            barCodeBox = new TextBox();
            AddProductBtn = new Button();
            notesLbl = new Label();
            noteBox = new TextBox();
            stockLbl = new Label();
            stockBox = new TextBox();
            toDateLbl = new Label();
            colorlbl = new Label();
            discountLbl = new Label();
            discountBox = new TextBox();
            sellingPriceLbl = new Label();
            costLbl = new Label();
            sellingPriceBox = new TextBox();
            costBox = new TextBox();
            supplierLbl = new Label();
            SupplierComboBox = new ComboBox();
            categoryLbl = new Label();
            CatComboBox = new ComboBox();
            pNameLbl = new Label();
            productNameBox = new TextBox();
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
            existProductsLbl = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            searchProductBox = new TextBox();
            searchProductLbl = new Label();
            searchLbl = new PictureBox();
            SizeBox = new ComboBox();
            ColorBox = new TextBox();
            updatebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLbl).BeginInit();
            SuspendLayout();
            // 
            // barCodeLbl
            // 
            barCodeLbl.Anchor = AnchorStyles.None;
            barCodeLbl.AutoSize = true;
            barCodeLbl.BackColor = Color.FromArgb(24, 30, 46);
            barCodeLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            barCodeLbl.ForeColor = Color.White;
            barCodeLbl.Location = new Point(1333, 126);
            barCodeLbl.Name = "barCodeLbl";
            barCodeLbl.Padding = new Padding(0, 0, 0, 5);
            barCodeLbl.RightToLeft = RightToLeft.Yes;
            barCodeLbl.Size = new Size(63, 28);
            barCodeLbl.TabIndex = 14;
            barCodeLbl.Text = "الباركود";
            // 
            // barCodeBox
            // 
            barCodeBox.Anchor = AnchorStyles.None;
            barCodeBox.BackColor = Color.FromArgb(24, 30, 46);
            barCodeBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            barCodeBox.ForeColor = Color.White;
            barCodeBox.Location = new Point(1084, 147);
            barCodeBox.Name = "barCodeBox";
            barCodeBox.Size = new Size(342, 47);
            barCodeBox.TabIndex = 16;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Anchor = AnchorStyles.None;
            AddProductBtn.BackColor = Color.LimeGreen;
            AddProductBtn.FlatStyle = FlatStyle.Popup;
            AddProductBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductBtn.ForeColor = Color.Snow;
            AddProductBtn.Location = new Point(856, 405);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.RightToLeft = RightToLeft.Yes;
            AddProductBtn.Size = new Size(153, 56);
            AddProductBtn.TabIndex = 21;
            AddProductBtn.Text = "إضافة";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // notesLbl
            // 
            notesLbl.Anchor = AnchorStyles.None;
            notesLbl.AutoSize = true;
            notesLbl.BackColor = Color.FromArgb(24, 30, 46);
            notesLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            notesLbl.ForeColor = Color.White;
            notesLbl.Location = new Point(616, 313);
            notesLbl.Name = "notesLbl";
            notesLbl.Padding = new Padding(0, 0, 0, 5);
            notesLbl.RightToLeft = RightToLeft.Yes;
            notesLbl.Size = new Size(74, 28);
            notesLbl.TabIndex = 35;
            notesLbl.Text = "ملاحظات";
            // 
            // noteBox
            // 
            noteBox.Anchor = AnchorStyles.None;
            noteBox.BackColor = Color.FromArgb(24, 30, 46);
            noteBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            noteBox.ForeColor = Color.White;
            noteBox.Location = new Point(38, 329);
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(658, 47);
            noteBox.TabIndex = 36;
            // 
            // stockLbl
            // 
            stockLbl.Anchor = AnchorStyles.None;
            stockLbl.AutoSize = true;
            stockLbl.BackColor = Color.FromArgb(24, 30, 46);
            stockLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            stockLbl.ForeColor = Color.White;
            stockLbl.Location = new Point(1340, 222);
            stockLbl.Name = "stockLbl";
            stockLbl.Padding = new Padding(0, 0, 0, 5);
            stockLbl.RightToLeft = RightToLeft.Yes;
            stockLbl.Size = new Size(54, 28);
            stockLbl.TabIndex = 33;
            stockLbl.Text = "الكمية";
            // 
            // stockBox
            // 
            stockBox.Anchor = AnchorStyles.None;
            stockBox.BackColor = Color.FromArgb(24, 30, 46);
            stockBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            stockBox.ForeColor = Color.White;
            stockBox.Location = new Point(1084, 245);
            stockBox.Name = "stockBox";
            stockBox.Size = new Size(342, 47);
            stockBox.TabIndex = 34;
            // 
            // toDateLbl
            // 
            toDateLbl.Anchor = AnchorStyles.None;
            toDateLbl.AutoSize = true;
            toDateLbl.BackColor = Color.FromArgb(24, 30, 46);
            toDateLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            toDateLbl.ForeColor = Color.White;
            toDateLbl.Location = new Point(991, 307);
            toDateLbl.Name = "toDateLbl";
            toDateLbl.Padding = new Padding(0, 0, 0, 5);
            toDateLbl.RightToLeft = RightToLeft.Yes;
            toDateLbl.Size = new Size(63, 28);
            toDateLbl.TabIndex = 32;
            toDateLbl.Text = "المقاس";
            // 
            // colorlbl
            // 
            colorlbl.Anchor = AnchorStyles.None;
            colorlbl.AutoSize = true;
            colorlbl.BackColor = Color.FromArgb(24, 30, 46);
            colorlbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            colorlbl.ForeColor = Color.White;
            colorlbl.Location = new Point(1364, 300);
            colorlbl.Name = "colorlbl";
            colorlbl.Padding = new Padding(0, 0, 0, 5);
            colorlbl.RightToLeft = RightToLeft.Yes;
            colorlbl.Size = new Size(46, 28);
            colorlbl.TabIndex = 30;
            colorlbl.Text = "اللون";
            // 
            // discountLbl
            // 
            discountLbl.Anchor = AnchorStyles.None;
            discountLbl.AutoSize = true;
            discountLbl.BackColor = Color.FromArgb(24, 30, 46);
            discountLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            discountLbl.ForeColor = Color.White;
            discountLbl.Location = new Point(596, 229);
            discountLbl.Name = "discountLbl";
            discountLbl.Padding = new Padding(0, 0, 0, 5);
            discountLbl.RightToLeft = RightToLeft.Yes;
            discountLbl.Size = new Size(97, 28);
            discountLbl.TabIndex = 27;
            discountLbl.Text = "نسبة الخصم";
            // 
            // discountBox
            // 
            discountBox.Anchor = AnchorStyles.None;
            discountBox.BackColor = Color.FromArgb(24, 30, 46);
            discountBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            discountBox.ForeColor = Color.White;
            discountBox.Location = new Point(381, 251);
            discountBox.Name = "discountBox";
            discountBox.Size = new Size(315, 47);
            discountBox.TabIndex = 28;
            discountBox.Text = "0";
            discountBox.TextChanged += discountBox_TextChanged;
            // 
            // sellingPriceLbl
            // 
            sellingPriceLbl.Anchor = AnchorStyles.None;
            sellingPriceLbl.AutoSize = true;
            sellingPriceLbl.BackColor = Color.FromArgb(24, 30, 46);
            sellingPriceLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            sellingPriceLbl.ForeColor = Color.White;
            sellingPriceLbl.Location = new Point(256, 223);
            sellingPriceLbl.Name = "sellingPriceLbl";
            sellingPriceLbl.Padding = new Padding(0, 0, 0, 5);
            sellingPriceLbl.RightToLeft = RightToLeft.Yes;
            sellingPriceLbl.Size = new Size(78, 28);
            sellingPriceLbl.TabIndex = 23;
            sellingPriceLbl.Text = "سعر البيع";
            // 
            // costLbl
            // 
            costLbl.Anchor = AnchorStyles.None;
            costLbl.AutoSize = true;
            costLbl.BackColor = Color.FromArgb(24, 30, 46);
            costLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            costLbl.ForeColor = Color.White;
            costLbl.Location = new Point(964, 230);
            costLbl.Name = "costLbl";
            costLbl.Padding = new Padding(0, 0, 0, 5);
            costLbl.RightToLeft = RightToLeft.Yes;
            costLbl.Size = new Size(86, 28);
            costLbl.TabIndex = 25;
            costLbl.Text = "سعر الشراء";
            // 
            // sellingPriceBox
            // 
            sellingPriceBox.Anchor = AnchorStyles.None;
            sellingPriceBox.BackColor = Color.FromArgb(24, 30, 46);
            sellingPriceBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sellingPriceBox.ForeColor = Color.White;
            sellingPriceBox.Location = new Point(38, 245);
            sellingPriceBox.Name = "sellingPriceBox";
            sellingPriceBox.Size = new Size(307, 47);
            sellingPriceBox.TabIndex = 26;
            // 
            // costBox
            // 
            costBox.Anchor = AnchorStyles.None;
            costBox.BackColor = Color.FromArgb(24, 30, 46);
            costBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            costBox.ForeColor = Color.White;
            costBox.Location = new Point(716, 251);
            costBox.Name = "costBox";
            costBox.Size = new Size(337, 47);
            costBox.TabIndex = 24;
            // 
            // supplierLbl
            // 
            supplierLbl.Anchor = AnchorStyles.None;
            supplierLbl.AutoSize = true;
            supplierLbl.BackColor = Color.FromArgb(24, 30, 46);
            supplierLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            supplierLbl.ForeColor = Color.White;
            supplierLbl.Location = new Point(282, 126);
            supplierLbl.Name = "supplierLbl";
            supplierLbl.Padding = new Padding(0, 0, 0, 5);
            supplierLbl.RightToLeft = RightToLeft.Yes;
            supplierLbl.Size = new Size(54, 28);
            supplierLbl.TabIndex = 22;
            supplierLbl.Text = "المورد";
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.Anchor = AnchorStyles.None;
            SupplierComboBox.BackColor = Color.FromArgb(24, 30, 46);
            SupplierComboBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SupplierComboBox.ForeColor = Color.White;
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Location = new Point(38, 148);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.RightToLeft = RightToLeft.Yes;
            SupplierComboBox.Size = new Size(307, 49);
            SupplierComboBox.TabIndex = 21;
            // 
            // categoryLbl
            // 
            categoryLbl.Anchor = AnchorStyles.None;
            categoryLbl.AutoSize = true;
            categoryLbl.BackColor = Color.FromArgb(24, 30, 46);
            categoryLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLbl.ForeColor = Color.White;
            categoryLbl.Location = new Point(628, 127);
            categoryLbl.Name = "categoryLbl";
            categoryLbl.Padding = new Padding(0, 0, 0, 5);
            categoryLbl.RightToLeft = RightToLeft.Yes;
            categoryLbl.Size = new Size(60, 28);
            categoryLbl.TabIndex = 20;
            categoryLbl.Text = "الصنف";
            // 
            // CatComboBox
            // 
            CatComboBox.Anchor = AnchorStyles.None;
            CatComboBox.BackColor = Color.FromArgb(24, 30, 46);
            CatComboBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CatComboBox.ForeColor = Color.White;
            CatComboBox.FormattingEnabled = true;
            CatComboBox.Location = new Point(381, 148);
            CatComboBox.Name = "CatComboBox";
            CatComboBox.RightToLeft = RightToLeft.Yes;
            CatComboBox.Size = new Size(315, 49);
            CatComboBox.TabIndex = 19;
            // 
            // pNameLbl
            // 
            pNameLbl.Anchor = AnchorStyles.None;
            pNameLbl.AutoSize = true;
            pNameLbl.BackColor = Color.FromArgb(24, 30, 46);
            pNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            pNameLbl.ForeColor = Color.White;
            pNameLbl.Location = new Point(957, 124);
            pNameLbl.Name = "pNameLbl";
            pNameLbl.Padding = new Padding(0, 0, 0, 5);
            pNameLbl.RightToLeft = RightToLeft.Yes;
            pNameLbl.Size = new Size(85, 28);
            pNameLbl.TabIndex = 17;
            pNameLbl.Text = "اسم المنتج";
            // 
            // productNameBox
            // 
            productNameBox.Anchor = AnchorStyles.None;
            productNameBox.BackColor = Color.FromArgb(24, 30, 46);
            productNameBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            productNameBox.ForeColor = Color.White;
            productNameBox.Location = new Point(716, 147);
            productNameBox.Name = "productNameBox";
            productNameBox.Size = new Size(337, 47);
            productNameBox.TabIndex = 18;
            // 
            // Items
            // 
            Items.AllowUserToAddRows = false;
            Items.AllowUserToDeleteRows = false;
            Items.Anchor = AnchorStyles.None;
            Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Items.BackgroundColor = Color.Snow;
            Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items.Columns.AddRange(new DataGridViewColumn[] { _Barcode, _Name, category, Supplier, _Quantity, _cost, _discount, Sale, _color, _size, notes });
            Items.Location = new Point(23, 477);
            Items.Name = "Items";
            Items.ReadOnly = true;
            Items.RightToLeft = RightToLeft.Yes;
            Items.RowHeadersWidth = 51;
            Items.RowTemplate.Height = 29;
            Items.Size = new Size(1454, 453);
            Items.TabIndex = 21;
            Items.RowHeaderMouseClick += Items_RowHeaderMouseClick;
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
            // existProductsLbl
            // 
            existProductsLbl.Anchor = AnchorStyles.None;
            existProductsLbl.AutoSize = true;
            existProductsLbl.BackColor = Color.FromArgb(27, 156, 133);
            existProductsLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            existProductsLbl.ForeColor = Color.White;
            existProductsLbl.Location = new Point(1197, 419);
            existProductsLbl.Name = "existProductsLbl";
            existProductsLbl.Padding = new Padding(0, 0, 0, 5);
            existProductsLbl.RightToLeft = RightToLeft.Yes;
            existProductsLbl.Size = new Size(183, 36);
            existProductsLbl.TabIndex = 50;
            existProductsLbl.Text = "المنتجات المضافة";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1386, 413);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(27, 156, 133);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 5);
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(145, 43);
            label1.TabIndex = 53;
            label1.Text = "إضافة منتج";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1238, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 61);
            panel1.TabIndex = 54;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1396, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            // 
            // searchProductBox
            // 
            searchProductBox.Anchor = AnchorStyles.None;
            searchProductBox.BackColor = Color.FromArgb(24, 30, 46);
            searchProductBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            searchProductBox.ForeColor = Color.White;
            searchProductBox.Location = new Point(38, 405);
            searchProductBox.Multiline = true;
            searchProductBox.Name = "searchProductBox";
            searchProductBox.Size = new Size(403, 56);
            searchProductBox.TabIndex = 56;
            searchProductBox.TextChanged += searchProductBox_TextChanged;
            // 
            // searchProductLbl
            // 
            searchProductLbl.Anchor = AnchorStyles.None;
            searchProductLbl.AutoSize = true;
            searchProductLbl.BackColor = Color.FromArgb(24, 30, 46);
            searchProductLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            searchProductLbl.ForeColor = Color.White;
            searchProductLbl.Location = new Point(356, 392);
            searchProductLbl.Name = "searchProductLbl";
            searchProductLbl.Padding = new Padding(0, 0, 0, 5);
            searchProductLbl.RightToLeft = RightToLeft.Yes;
            searchProductLbl.Size = new Size(85, 25);
            searchProductLbl.TabIndex = 57;
            searchProductLbl.Text = "ابحث بالاسم";
            // 
            // searchLbl
            // 
            searchLbl.Anchor = AnchorStyles.None;
            searchLbl.Image = (Image)resources.GetObject("searchLbl.Image");
            searchLbl.Location = new Point(461, 405);
            searchLbl.Name = "searchLbl";
            searchLbl.Size = new Size(62, 56);
            searchLbl.SizeMode = PictureBoxSizeMode.Zoom;
            searchLbl.TabIndex = 58;
            searchLbl.TabStop = false;
            // 
            // SizeBox
            // 
            SizeBox.Anchor = AnchorStyles.None;
            SizeBox.BackColor = Color.FromArgb(24, 30, 46);
            SizeBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SizeBox.ForeColor = Color.White;
            SizeBox.FormattingEnabled = true;
            SizeBox.Items.AddRange(new object[] { "Small", "Medium", "Large", "XLarge", "XXLarge", "XXXLarge", "Custom" });
            SizeBox.Location = new Point(716, 329);
            SizeBox.Name = "SizeBox";
            SizeBox.RightToLeft = RightToLeft.Yes;
            SizeBox.Size = new Size(337, 49);
            SizeBox.TabIndex = 61;
            // 
            // ColorBox
            // 
            ColorBox.Anchor = AnchorStyles.None;
            ColorBox.BackColor = Color.FromArgb(24, 30, 46);
            ColorBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ColorBox.ForeColor = Color.White;
            ColorBox.Location = new Point(1084, 331);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(342, 47);
            ColorBox.TabIndex = 62;
            // 
            // updatebtn
            // 
            updatebtn.Anchor = AnchorStyles.None;
            updatebtn.BackColor = Color.LimeGreen;
            updatebtn.FlatStyle = FlatStyle.Popup;
            updatebtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            updatebtn.ForeColor = Color.Snow;
            updatebtn.Location = new Point(667, 405);
            updatebtn.Name = "updatebtn";
            updatebtn.RightToLeft = RightToLeft.Yes;
            updatebtn.Size = new Size(153, 56);
            updatebtn.TabIndex = 63;
            updatebtn.Text = "تعديل";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // AddProductPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(updatebtn);
            Controls.Add(ColorBox);
            Controls.Add(SizeBox);
            Controls.Add(pictureBox2);
            Controls.Add(searchLbl);
            Controls.Add(searchProductLbl);
            Controls.Add(searchProductBox);
            Controls.Add(barCodeLbl);
            Controls.Add(pNameLbl);
            Controls.Add(categoryLbl);
            Controls.Add(supplierLbl);
            Controls.Add(costLbl);
            Controls.Add(panel1);
            Controls.Add(Items);
            Controls.Add(pictureBox1);
            Controls.Add(AddProductBtn);
            Controls.Add(notesLbl);
            Controls.Add(existProductsLbl);
            Controls.Add(noteBox);
            Controls.Add(productNameBox);
            Controls.Add(stockLbl);
            Controls.Add(barCodeBox);
            Controls.Add(stockBox);
            Controls.Add(CatComboBox);
            Controls.Add(SupplierComboBox);
            Controls.Add(discountLbl);
            Controls.Add(discountBox);
            Controls.Add(costBox);
            Controls.Add(sellingPriceLbl);
            Controls.Add(sellingPriceBox);
            Controls.Add(colorlbl);
            Controls.Add(toDateLbl);
            MinimumSize = new Size(1244, 752);
            Name = "AddProductPage";
            Size = new Size(1496, 949);
            Load += AddProductPage_Load;
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label barCodeLbl;
        private TextBox barCodeBox;
        private Label categoryLbl;
        private ComboBox CatComboBox;
        private Label pNameLbl;
        private TextBox productNameBox;
        private Label costLbl;
        private TextBox sellingPriceBox;
        private Label sellingPriceLbl;
        private TextBox costBox;
        private Label supplierLbl;
        private ComboBox SupplierComboBox;
        private Label stockLbl;
        private TextBox stockBox;
        private Label toDateLbl;
        private Label colorlbl;
        private Label discountLbl;
        private TextBox discountBox;
        private Button AddProductBtn;
        private Label notesLbl;
        private TextBox noteBox;
        private DataGridView Items;
        private Label existProductsLbl;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox searchProductBox;
        private Label searchProductLbl;
        private PictureBox searchLbl;
        private ComboBox SizeBox;
        private TextBox ColorBox;
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
        private Button updatebtn;
    }
}
