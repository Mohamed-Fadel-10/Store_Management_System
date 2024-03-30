namespace Store_System.UI.ControlPanelUi
{
    partial class SaleBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleBill));
            Addbtn = new Button();
            Savebtn = new Button();
            label20 = new Label();
            StockBox = new ComboBox();
            label19 = new Label();
            label18 = new Label();
            FaturaDiscountBox = new TextBox();
            label17 = new Label();
            AfterDiscount = new TextBox();
            label16 = new Label();
            PaidUp = new TextBox();
            label15 = new Label();
            TotalPriceBox = new TextBox();
            label14 = new Label();
            NotesBox = new TextBox();
            label12 = new Label();
            SizeBox = new ComboBox();
            label13 = new Label();
            label8 = new Label();
            QuantityBox = new TextBox();
            label7 = new Label();
            ClassificationBox = new ComboBox();
            label6 = new Label();
            ProductnameBox = new TextBox();
            label5 = new Label();
            ProductCodeBox = new TextBox();
            label1 = new Label();
            label4 = new Label();
            SearchBox = new TextBox();
            label2 = new Label();
            BillCodeBox = new TextBox();
            Items = new DataGridView();
            _Barcode = new DataGridViewTextBoxColumn();
            _Name = new DataGridViewTextBoxColumn();
            _Classification = new DataGridViewTextBoxColumn();
            _Quantity = new DataGridViewTextBoxColumn();
            _Color = new DataGridViewTextBoxColumn();
            _Size = new DataGridViewTextBoxColumn();
            SalePricePerOne = new DataGridViewTextBoxColumn();
            _Discount = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            _notes = new DataGridViewTextBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            OrderID = new DataGridViewTextBoxColumn();
            Printbtn = new Button();
            panel1 = new Panel();
            button1 = new Button();
            CustomerNameBox = new TextBox();
            label3 = new Label();
            label9 = new Label();
            SellingPrice = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ColorBox = new TextBox();
            Updatebtn = new Button();
            deletebtn = new Button();
            _discountBox = new TextBox();
            label10 = new Label();
            productID = new TextBox();
            Date = new Label();
            cashierNameBox = new TextBox();
            UserIDBox = new TextBox();
            customerIDBox = new TextBox();
            CustomerPhone = new TextBox();
            totalQuantityBox = new TextBox();
            label11 = new Label();
            searchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Addbtn
            // 
            Addbtn.Anchor = AnchorStyles.None;
            Addbtn.BackColor = Color.LimeGreen;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(165, 247);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(110, 55);
            Addbtn.TabIndex = 124;
            Addbtn.Text = "إضافة";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // Savebtn
            // 
            Savebtn.Anchor = AnchorStyles.None;
            Savebtn.BackColor = Color.LimeGreen;
            Savebtn.FlatStyle = FlatStyle.Flat;
            Savebtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            Savebtn.ForeColor = Color.White;
            Savebtn.Location = new Point(196, 888);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(150, 46);
            Savebtn.TabIndex = 123;
            Savebtn.Text = "حفظ";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(213, 822);
            label20.Name = "label20";
            label20.Size = new Size(51, 23);
            label20.TabIndex = 122;
            label20.Text = "الخزنة";
            // 
            // StockBox
            // 
            StockBox.BackColor = Color.FromArgb(24, 30, 46);
            StockBox.Enabled = false;
            StockBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StockBox.ForeColor = Color.White;
            StockBox.FormattingEnabled = true;
            StockBox.Location = new Point(49, 839);
            StockBox.Name = "StockBox";
            StockBox.RightToLeft = RightToLeft.Yes;
            StockBox.Size = new Size(225, 36);
            StockBox.TabIndex = 121;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(476, 820);
            label19.Name = "label19";
            label19.Size = new Size(70, 23);
            label19.TabIndex = 120;
            label19.Text = "الموظف";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(1157, 822);
            label18.Name = "label18";
            label18.Size = new Size(57, 23);
            label18.TabIndex = 117;
            label18.Text = "الخصم";
            // 
            // FaturaDiscountBox
            // 
            FaturaDiscountBox.Anchor = AnchorStyles.None;
            FaturaDiscountBox.BackColor = Color.FromArgb(24, 30, 46);
            FaturaDiscountBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FaturaDiscountBox.ForeColor = Color.White;
            FaturaDiscountBox.Location = new Point(1015, 840);
            FaturaDiscountBox.Name = "FaturaDiscountBox";
            FaturaDiscountBox.RightToLeft = RightToLeft.Yes;
            FaturaDiscountBox.Size = new Size(209, 34);
            FaturaDiscountBox.TabIndex = 118;
            FaturaDiscountBox.TextChanged += FaturaDiscountBox_TextChanged;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(906, 822);
            label17.Name = "label17";
            label17.Size = new Size(87, 23);
            label17.TabIndex = 115;
            label17.Text = "بعد الخصم";
            // 
            // AfterDiscount
            // 
            AfterDiscount.Anchor = AnchorStyles.None;
            AfterDiscount.BackColor = Color.FromArgb(24, 30, 46);
            AfterDiscount.Enabled = false;
            AfterDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AfterDiscount.ForeColor = Color.White;
            AfterDiscount.Location = new Point(791, 840);
            AfterDiscount.Name = "AfterDiscount";
            AfterDiscount.RightToLeft = RightToLeft.Yes;
            AfterDiscount.Size = new Size(209, 34);
            AfterDiscount.TabIndex = 116;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(701, 822);
            label16.Name = "label16";
            label16.Size = new Size(67, 23);
            label16.TabIndex = 113;
            label16.Text = "المدفوع";
            // 
            // PaidUp
            // 
            PaidUp.Anchor = AnchorStyles.None;
            PaidUp.BackColor = Color.FromArgb(24, 30, 46);
            PaidUp.Enabled = false;
            PaidUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PaidUp.ForeColor = Color.White;
            PaidUp.Location = new Point(568, 840);
            PaidUp.Name = "PaidUp";
            PaidUp.RightToLeft = RightToLeft.Yes;
            PaidUp.Size = new Size(209, 34);
            PaidUp.TabIndex = 114;
            PaidUp.TextChanged += PaidUp_TextChanged;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(1379, 822);
            label15.Name = "label15";
            label15.Size = new Size(58, 23);
            label15.TabIndex = 111;
            label15.Text = "إجمالى";
            // 
            // TotalPriceBox
            // 
            TotalPriceBox.Anchor = AnchorStyles.None;
            TotalPriceBox.BackColor = Color.FromArgb(24, 30, 46);
            TotalPriceBox.Enabled = false;
            TotalPriceBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPriceBox.ForeColor = Color.White;
            TotalPriceBox.Location = new Point(1237, 840);
            TotalPriceBox.Name = "TotalPriceBox";
            TotalPriceBox.RightToLeft = RightToLeft.Yes;
            TotalPriceBox.Size = new Size(209, 34);
            TotalPriceBox.TabIndex = 112;
            TotalPriceBox.TextChanged += TotalPriceBox_TextChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(741, 238);
            label14.Name = "label14";
            label14.Size = new Size(74, 23);
            label14.TabIndex = 109;
            label14.Text = "ملاحظات";
            // 
            // NotesBox
            // 
            NotesBox.Anchor = AnchorStyles.None;
            NotesBox.BackColor = Color.FromArgb(24, 30, 46);
            NotesBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NotesBox.ForeColor = Color.White;
            NotesBox.Location = new Point(310, 257);
            NotesBox.Name = "NotesBox";
            NotesBox.RightToLeft = RightToLeft.Yes;
            NotesBox.Size = new Size(518, 34);
            NotesBox.TabIndex = 110;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1081, 235);
            label12.Name = "label12";
            label12.Size = new Size(53, 23);
            label12.TabIndex = 108;
            label12.Text = "مقاس";
            // 
            // SizeBox
            // 
            SizeBox.BackColor = Color.FromArgb(24, 30, 46);
            SizeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SizeBox.ForeColor = Color.White;
            SizeBox.FormattingEnabled = true;
            SizeBox.Items.AddRange(new object[] { "Small", "Medium", "Large", "XLarge", "XXLarge", "XXXLarge", "Custome" });
            SizeBox.Location = new Point(848, 255);
            SizeBox.Name = "SizeBox";
            SizeBox.RightToLeft = RightToLeft.Yes;
            SizeBox.Size = new Size(295, 36);
            SizeBox.TabIndex = 107;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(1391, 237);
            label13.Name = "label13";
            label13.Size = new Size(46, 23);
            label13.TabIndex = 106;
            label13.Text = "اللون";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(512, 150);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 97;
            label8.Text = "الكمية";
            // 
            // QuantityBox
            // 
            QuantityBox.Anchor = AnchorStyles.None;
            QuantityBox.BackColor = Color.FromArgb(24, 30, 46);
            QuantityBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityBox.ForeColor = Color.White;
            QuantityBox.Location = new Point(402, 170);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.RightToLeft = RightToLeft.Yes;
            QuantityBox.Size = new Size(171, 34);
            QuantityBox.TabIndex = 98;
            QuantityBox.Text = "1";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(737, 152);
            label7.Name = "label7";
            label7.Size = new Size(82, 23);
            label7.TabIndex = 96;
            label7.Text = "نوع المنتج";
            // 
            // ClassificationBox
            // 
            ClassificationBox.BackColor = Color.FromArgb(24, 30, 46);
            ClassificationBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClassificationBox.ForeColor = Color.White;
            ClassificationBox.FormattingEnabled = true;
            ClassificationBox.Location = new Point(595, 170);
            ClassificationBox.Name = "ClassificationBox";
            ClassificationBox.RightToLeft = RightToLeft.Yes;
            ClassificationBox.Size = new Size(233, 36);
            ClassificationBox.TabIndex = 95;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1050, 152);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 93;
            label6.Text = "إسم المنتج";
            // 
            // ProductnameBox
            // 
            ProductnameBox.Anchor = AnchorStyles.None;
            ProductnameBox.BackColor = Color.FromArgb(24, 30, 46);
            ProductnameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductnameBox.ForeColor = Color.White;
            ProductnameBox.Location = new Point(848, 170);
            ProductnameBox.Name = "ProductnameBox";
            ProductnameBox.RightToLeft = RightToLeft.Yes;
            ProductnameBox.Size = new Size(295, 34);
            ProductnameBox.TabIndex = 94;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1352, 152);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 91;
            label5.Text = "كود المنتج";
            // 
            // ProductCodeBox
            // 
            ProductCodeBox.Anchor = AnchorStyles.None;
            ProductCodeBox.BackColor = Color.FromArgb(24, 30, 46);
            ProductCodeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductCodeBox.ForeColor = Color.White;
            ProductCodeBox.Location = new Point(1157, 170);
            ProductCodeBox.Name = "ProductCodeBox";
            ProductCodeBox.RightToLeft = RightToLeft.Yes;
            ProductCodeBox.Size = new Size(287, 34);
            ProductCodeBox.TabIndex = 92;
            ProductCodeBox.TextChanged += ProductCodeBox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(127, 38);
            label1.TabIndex = 0;
            label1.Text = "فاتورة بيع";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(318, 38);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 90;
            label4.Text = "البحث";
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.None;
            SearchBox.BackColor = Color.FromArgb(24, 30, 46);
            SearchBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.ForeColor = Color.White;
            SearchBox.Location = new Point(142, 56);
            SearchBox.Name = "SearchBox";
            SearchBox.RightToLeft = RightToLeft.Yes;
            SearchBox.Size = new Size(237, 39);
            SearchBox.TabIndex = 89;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1137, 37);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 85;
            label2.Text = "رقم الفاتورة";
            // 
            // BillCodeBox
            // 
            BillCodeBox.Anchor = AnchorStyles.None;
            BillCodeBox.BackColor = Color.FromArgb(24, 30, 46);
            BillCodeBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BillCodeBox.ForeColor = Color.White;
            BillCodeBox.Location = new Point(947, 56);
            BillCodeBox.Name = "BillCodeBox";
            BillCodeBox.RightToLeft = RightToLeft.Yes;
            BillCodeBox.Size = new Size(290, 39);
            BillCodeBox.TabIndex = 86;
            // 
            // Items
            // 
            Items.Anchor = AnchorStyles.None;
            Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Items.BackgroundColor = Color.Snow;
            Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items.Columns.AddRange(new DataGridViewColumn[] { _Barcode, _Name, _Classification, _Quantity, _Color, _Size, SalePricePerOne, _Discount, Total, _notes, product_id, OrderID });
            Items.Location = new Point(26, 332);
            Items.Name = "Items";
            Items.RightToLeft = RightToLeft.Yes;
            Items.RowHeadersWidth = 51;
            Items.RowTemplate.Height = 29;
            Items.Size = new Size(1427, 480);
            Items.TabIndex = 84;
            Items.RowHeaderMouseClick += Items_RowHeaderMouseClick;
            // 
            // _Barcode
            // 
            _Barcode.HeaderText = "الكود";
            _Barcode.MinimumWidth = 6;
            _Barcode.Name = "_Barcode";
            // 
            // _Name
            // 
            _Name.HeaderText = "إسم المنتج";
            _Name.MinimumWidth = 6;
            _Name.Name = "_Name";
            // 
            // _Classification
            // 
            _Classification.HeaderText = "التصنيف";
            _Classification.MinimumWidth = 6;
            _Classification.Name = "_Classification";
            // 
            // _Quantity
            // 
            _Quantity.HeaderText = "الكمية";
            _Quantity.MinimumWidth = 6;
            _Quantity.Name = "_Quantity";
            // 
            // _Color
            // 
            _Color.HeaderText = "اللون";
            _Color.MinimumWidth = 6;
            _Color.Name = "_Color";
            // 
            // _Size
            // 
            _Size.HeaderText = "المقاس";
            _Size.MinimumWidth = 6;
            _Size.Name = "_Size";
            // 
            // SalePricePerOne
            // 
            SalePricePerOne.HeaderText = "سعر القطعة";
            SalePricePerOne.MinimumWidth = 6;
            SalePricePerOne.Name = "SalePricePerOne";
            // 
            // _Discount
            // 
            _Discount.HeaderText = "الخصم";
            _Discount.MinimumWidth = 6;
            _Discount.Name = "_Discount";
            // 
            // Total
            // 
            Total.HeaderText = "إجمالى";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // _notes
            // 
            _notes.HeaderText = "الوصف";
            _notes.MinimumWidth = 6;
            _notes.Name = "_notes";
            // 
            // product_id
            // 
            product_id.HeaderText = "رقم المنتج";
            product_id.MinimumWidth = 6;
            product_id.Name = "product_id";
            product_id.Visible = false;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "رقم الفاتورة";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.Visible = false;
            // 
            // Printbtn
            // 
            Printbtn.Anchor = AnchorStyles.None;
            Printbtn.BackColor = Color.DarkGoldenrod;
            Printbtn.FlatStyle = FlatStyle.Flat;
            Printbtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            Printbtn.ForeColor = Color.White;
            Printbtn.Location = new Point(49, 888);
            Printbtn.Name = "Printbtn";
            Printbtn.Size = new Size(131, 46);
            Printbtn.TabIndex = 83;
            Printbtn.Text = "طباعة";
            Printbtn.UseVisualStyleBackColor = false;
            Printbtn.Click += Printbtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1253, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 59);
            panel1.TabIndex = 82;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkGoldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(764, 56);
            button1.Name = "button1";
            button1.Size = new Size(143, 38);
            button1.TabIndex = 125;
            button1.Text = "إضافة عميل ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CustomerNameBox
            // 
            _CustomerNameBox.Anchor = AnchorStyles.None;
            _CustomerNameBox.BackColor = Color.FromArgb(24, 30, 46);
            _CustomerNameBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            _CustomerNameBox.ForeColor = Color.White;
            _CustomerNameBox.Location = new Point(418, 57);
            _CustomerNameBox.Name = "_CustomerNameBox";
            _CustomerNameBox.RightToLeft = RightToLeft.Yes;
            _CustomerNameBox.Size = new Size(335, 39);
            _CustomerNameBox.TabIndex = 126;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(654, 38);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 127;
            label3.Text = "إسم العميل";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(301, 150);
            label9.Name = "label9";
            label9.Size = new Size(78, 23);
            label9.TabIndex = 128;
            label9.Text = "سعر البيع";
            // 
            // SellingPrice
            // 
            SellingPrice.Anchor = AnchorStyles.None;
            SellingPrice.BackColor = Color.FromArgb(24, 30, 46);
            SellingPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SellingPrice.ForeColor = Color.White;
            SellingPrice.Location = new Point(221, 170);
            SellingPrice.Name = "SellingPrice";
            SellingPrice.RightToLeft = RightToLeft.Yes;
            SellingPrice.Size = new Size(166, 34);
            SellingPrice.TabIndex = 129;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1396, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 130;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(27, 156, 133);
            panel3.Enabled = false;
            panel3.Location = new Point(16, 316);
            panel3.Name = "panel3";
            panel3.Size = new Size(1448, 38);
            panel3.TabIndex = 132;
            // 
            // ColorBox
            // 
            ColorBox.Anchor = AnchorStyles.None;
            ColorBox.BackColor = Color.FromArgb(24, 30, 46);
            ColorBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ColorBox.ForeColor = Color.White;
            ColorBox.Location = new Point(1157, 257);
            ColorBox.Name = "ColorBox";
            ColorBox.RightToLeft = RightToLeft.Yes;
            ColorBox.Size = new Size(287, 34);
            ColorBox.TabIndex = 133;
            // 
            // Updatebtn
            // 
            Updatebtn.Anchor = AnchorStyles.None;
            Updatebtn.BackColor = Color.LimeGreen;
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            Updatebtn.ForeColor = Color.White;
            Updatebtn.Location = new Point(47, 247);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(110, 55);
            Updatebtn.TabIndex = 134;
            Updatebtn.Text = "تعديل";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Anchor = AnchorStyles.None;
            deletebtn.BackColor = Color.Firebrick;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.ForeColor = Color.White;
            deletebtn.Location = new Point(361, 888);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(150, 46);
            deletebtn.TabIndex = 135;
            deletebtn.Text = "حذف";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // _discountBox
            // 
            _discountBox.Anchor = AnchorStyles.None;
            _discountBox.BackColor = Color.FromArgb(24, 30, 46);
            _discountBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _discountBox.ForeColor = Color.White;
            _discountBox.Location = new Point(49, 170);
            _discountBox.Name = "_discountBox";
            _discountBox.RightToLeft = RightToLeft.Yes;
            _discountBox.Size = new Size(158, 34);
            _discountBox.TabIndex = 136;
            _discountBox.Text = "0";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(142, 150);
            label10.Name = "label10";
            label10.Size = new Size(57, 23);
            label10.TabIndex = 137;
            label10.Text = "الخصم";
            // 
            // productID
            // 
            productID.Anchor = AnchorStyles.None;
            productID.BackColor = Color.FromArgb(24, 30, 46);
            productID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productID.ForeColor = Color.White;
            productID.Location = new Point(947, 12);
            productID.Name = "productID";
            productID.RightToLeft = RightToLeft.Yes;
            productID.Size = new Size(154, 34);
            productID.TabIndex = 138;
            productID.Visible = false;
            // 
            // Date
            // 
            Date.Anchor = AnchorStyles.None;
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Date.ForeColor = Color.White;
            Date.Location = new Point(1263, 896);
            Date.Name = "Date";
            Date.Size = new Size(153, 38);
            Date.TabIndex = 139;
            Date.Text = "3/11/2024";
            // 
            // cashierNameBox
            // 
            cashierNameBox.Anchor = AnchorStyles.None;
            cashierNameBox.BackColor = Color.FromArgb(24, 30, 46);
            cashierNameBox.Enabled = false;
            cashierNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cashierNameBox.ForeColor = Color.White;
            cashierNameBox.Location = new Point(288, 838);
            cashierNameBox.Name = "cashierNameBox";
            cashierNameBox.RightToLeft = RightToLeft.Yes;
            cashierNameBox.Size = new Size(266, 34);
            cashierNameBox.TabIndex = 140;
            // 
            // UserIDBox
            // 
            UserIDBox.Anchor = AnchorStyles.None;
            UserIDBox.BackColor = Color.FromArgb(24, 30, 46);
            UserIDBox.Enabled = false;
            UserIDBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserIDBox.ForeColor = Color.White;
            UserIDBox.Location = new Point(568, 896);
            UserIDBox.Name = "UserIDBox";
            UserIDBox.RightToLeft = RightToLeft.Yes;
            UserIDBox.Size = new Size(140, 34);
            UserIDBox.TabIndex = 141;
            UserIDBox.Visible = false;
            // 
            // customerIDBox
            // 
            customerIDBox.Anchor = AnchorStyles.None;
            customerIDBox.BackColor = Color.FromArgb(24, 30, 46);
            customerIDBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            customerIDBox.ForeColor = Color.White;
            customerIDBox.Location = new Point(418, 17);
            customerIDBox.Name = "customerIDBox";
            customerIDBox.RightToLeft = RightToLeft.Yes;
            customerIDBox.Size = new Size(109, 25);
            customerIDBox.TabIndex = 142;
            customerIDBox.Visible = false;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.None;
            searchBtn.BackColor = Color.FromArgb(27, 156, 133);
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(47, 56);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(77, 38);
            searchBtn.TabIndex = 143;
            searchBtn.Text = "بحث";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // CustomerPhone
            // 
            CustomerPhone.Anchor = AnchorStyles.None;
            CustomerPhone.BackColor = Color.FromArgb(24, 30, 46);
            CustomerPhone.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerPhone.ForeColor = Color.White;
            CustomerPhone.Location = new Point(517, 21);
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.RightToLeft = RightToLeft.Yes;
            CustomerPhone.Size = new Size(165, 25);
            CustomerPhone.TabIndex = 143;
            CustomerPhone.Visible = false;
            // 
            // totalQuantityBox
            // 
            totalQuantityBox.Anchor = AnchorStyles.None;
            totalQuantityBox.BackColor = Color.FromArgb(24, 30, 46);
            totalQuantityBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalQuantityBox.ForeColor = Color.White;
            totalQuantityBox.Location = new Point(1015, 909);
            totalQuantityBox.Name = "totalQuantityBox";
            totalQuantityBox.RightToLeft = RightToLeft.Yes;
            totalQuantityBox.Size = new Size(103, 25);
            totalQuantityBox.TabIndex = 144;
            totalQuantityBox.Visible = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(1124, 911);
            label11.Name = "label11";
            label11.Size = new Size(86, 23);
            label11.TabIndex = 145;
            label11.Text = "عدد القطع";
            label11.Visible = false;
            // 
            // SaleBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(label11);
            Controls.Add(totalQuantityBox);
            Controls.Add(CustomerPhone);
            Controls.Add(searchBtn);
            Controls.Add(customerIDBox);
            Controls.Add(UserIDBox);
            Controls.Add(label19);
            Controls.Add(label13);
            Controls.Add(label7);
            Controls.Add(cashierNameBox);
            Controls.Add(Date);
            Controls.Add(productID);
            Controls.Add(label10);
            Controls.Add(_discountBox);
            Controls.Add(deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(ColorBox);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(SellingPrice);
            Controls.Add(label3);
            Controls.Add(CustomerNameBox);
            Controls.Add(button1);
            Controls.Add(Addbtn);
            Controls.Add(Savebtn);
            Controls.Add(label20);
            Controls.Add(StockBox);
            Controls.Add(label18);
            Controls.Add(FaturaDiscountBox);
            Controls.Add(label17);
            Controls.Add(AfterDiscount);
            Controls.Add(label16);
            Controls.Add(PaidUp);
            Controls.Add(label15);
            Controls.Add(TotalPriceBox);
            Controls.Add(label14);
            Controls.Add(NotesBox);
            Controls.Add(label12);
            Controls.Add(SizeBox);
            Controls.Add(label8);
            Controls.Add(QuantityBox);
            Controls.Add(ClassificationBox);
            Controls.Add(label6);
            Controls.Add(ProductnameBox);
            Controls.Add(label5);
            Controls.Add(ProductCodeBox);
            Controls.Add(label4);
            Controls.Add(SearchBox);
            Controls.Add(label2);
            Controls.Add(BillCodeBox);
            Controls.Add(Items);
            Controls.Add(Printbtn);
            Controls.Add(panel1);
            Controls.Add(panel3);
            MinimumSize = new Size(1496, 949);
            Name = "SaleBill";
            Size = new Size(1496, 949);
            Load += SaleBill_Load;
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Addbtn;
        private Button Savebtn;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox NotesBox;
        private Label label12;
        private ComboBox SizeBox;
        private Label label13;
        private Label label8;
        private TextBox QuantityBox;
        private Label label7;
        private ComboBox ClassificationBox;
        private Label label6;
        private TextBox ProductnameBox;
        private Label label5;
        private TextBox ProductCodeBox;
        private Label label1;
        private Label label4;
        private TextBox SearchBox;
        private Label label2;
        private DataGridView Items;
        private Button Printbtn;
        private Panel panel1;
        private Button button1;
        private Label label3;
        private Label label9;
        private TextBox SellingPrice;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox ColorBox;
        private Button Updatebtn;
        private Button deletebtn;
        private TextBox _discountBox;
        private Label label10;
        private TextBox productID;
        private Label Date;
        public TextBox cashierNameBox;
        public ComboBox StockBox;
        public TextBox UserIDBox;
        private TextBox customerIDBox;
        private DataGridViewTextBoxColumn _Barcode;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn _Classification;
        private DataGridViewTextBoxColumn _Quantity;
        private DataGridViewTextBoxColumn _Color;
        private DataGridViewTextBoxColumn _Size;
        private DataGridViewTextBoxColumn SalePricePerOne;
        private DataGridViewTextBoxColumn _Discount;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn _notes;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn OrderID;
        public TextBox FaturaDiscountBox;
        public TextBox AfterDiscount;
        public TextBox PaidUp;
        public TextBox TotalPriceBox;
        public TextBox BillCodeBox;
        public TextBox CustomerNameBox;
        public TextBox CustomerPhone;
        public TextBox totalQuantityBox;
        private Label label11;
        private Button searchBtn;
    }
}
