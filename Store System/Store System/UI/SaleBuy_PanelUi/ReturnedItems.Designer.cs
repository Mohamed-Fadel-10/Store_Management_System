namespace Store_System.UI.ControlPanelUi
{
    partial class ReturnedItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnedItems));
            label1 = new Label();
            Addbtn = new Button();
            Savebtn = new Button();
            label14 = new Label();
            NotesBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            _discountBox = new TextBox();
            label8 = new Label();
            QuantityBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            ProductnameBox = new TextBox();
            label5 = new Label();
            label2 = new Label();
            BillCodeBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ProductCodeBox = new TextBox();
            ColorBox = new TextBox();
            productID = new TextBox();
            ok = new Button();
            Items = new DataGridView();
            SizeBox = new ComboBox();
            ReturnedItemsGridview = new DataGridView();
            _Name = new DataGridViewTextBoxColumn();
            _barcode = new DataGridViewTextBoxColumn();
            _Size = new DataGridViewTextBoxColumn();
            _Color = new DataGridViewTextBoxColumn();
            _Quantity = new DataGridViewTextBoxColumn();
            _Category = new DataGridViewTextBoxColumn();
            _discount = new DataGridViewTextBoxColumn();
            _ReturnedID = new DataGridViewTextBoxColumn();
            _ProductID = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label9 = new Label();
            ReturnedID = new TextBox();
            CatComboBox = new TextBox();
            DeleteitemBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReturnedItemsGridview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(15, 6);
            label1.Name = "label1";
            label1.Size = new Size(126, 38);
            label1.TabIndex = 0;
            label1.Text = "مرتجع بيع";
            // 
            // Addbtn
            // 
            Addbtn.Anchor = AnchorStyles.None;
            Addbtn.BackColor = Color.LimeGreen;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(115, 246);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(225, 44);
            Addbtn.TabIndex = 166;
            Addbtn.Text = "إضافة الى المرتجعات";
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
            Savebtn.Location = new Point(55, 888);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(264, 49);
            Savebtn.TabIndex = 165;
            Savebtn.Text = "حفظ فاتورة المرتجعات";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(797, 230);
            label14.Name = "label14";
            label14.Size = new Size(95, 23);
            label14.TabIndex = 151;
            label14.Text = "سبب الارجاع";
            // 
            // NotesBox
            // 
            NotesBox.Anchor = AnchorStyles.None;
            NotesBox.BackColor = Color.FromArgb(24, 30, 46);
            NotesBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NotesBox.ForeColor = Color.White;
            NotesBox.Location = new Point(432, 243);
            NotesBox.Multiline = true;
            NotesBox.Name = "NotesBox";
            NotesBox.RightToLeft = RightToLeft.Yes;
            NotesBox.Size = new Size(460, 73);
            NotesBox.TabIndex = 152;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1145, 230);
            label12.Name = "label12";
            label12.Size = new Size(53, 23);
            label12.TabIndex = 150;
            label12.Text = "مقاس";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(1397, 230);
            label13.Name = "label13";
            label13.Size = new Size(46, 23);
            label13.TabIndex = 148;
            label13.Text = "اللون";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(234, 146);
            label11.Name = "label11";
            label11.Size = new Size(57, 23);
            label11.TabIndex = 145;
            label11.Text = "الخصم";
            // 
            // _discountBox
            // 
            _discountBox.Anchor = AnchorStyles.None;
            _discountBox.BackColor = Color.FromArgb(24, 30, 46);
            _discountBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _discountBox.ForeColor = Color.White;
            _discountBox.Location = new Point(165, 164);
            _discountBox.Name = "_discountBox";
            _discountBox.RightToLeft = RightToLeft.Yes;
            _discountBox.Size = new Size(138, 34);
            _discountBox.TabIndex = 146;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(413, 137);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 143;
            label8.Text = "الكمية";
            // 
            // QuantityBox
            // 
            QuantityBox.Anchor = AnchorStyles.None;
            QuantityBox.BackColor = Color.FromArgb(24, 30, 46);
            QuantityBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityBox.ForeColor = Color.White;
            QuantityBox.Location = new Point(338, 163);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.RightToLeft = RightToLeft.Yes;
            QuantityBox.Size = new Size(181, 34);
            QuantityBox.TabIndex = 144;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(760, 137);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 142;
            label7.Text = "التصنيف";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1106, 146);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 139;
            label6.Text = "إسم المنتج";
            // 
            // ProductnameBox
            // 
            ProductnameBox.Anchor = AnchorStyles.None;
            ProductnameBox.BackColor = Color.FromArgb(24, 30, 46);
            ProductnameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductnameBox.ForeColor = Color.White;
            ProductnameBox.Location = new Point(930, 164);
            ProductnameBox.Name = "ProductnameBox";
            ProductnameBox.RightToLeft = RightToLeft.Yes;
            ProductnameBox.Size = new Size(268, 34);
            ProductnameBox.TabIndex = 140;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1359, 145);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 137;
            label5.Text = "كود المنتج";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(919, 41);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 133;
            label2.Text = "رقم الفاتورة";
            // 
            // BillCodeBox
            // 
            BillCodeBox.Anchor = AnchorStyles.None;
            BillCodeBox.BackColor = Color.FromArgb(24, 30, 46);
            BillCodeBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BillCodeBox.ForeColor = Color.White;
            BillCodeBox.Location = new Point(755, 58);
            BillCodeBox.Name = "BillCodeBox";
            BillCodeBox.RightToLeft = RightToLeft.Yes;
            BillCodeBox.Size = new Size(268, 39);
            BillCodeBox.TabIndex = 134;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1243, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 61);
            panel1.TabIndex = 130;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(24, 30, 46);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1390, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(92, 85);
            panel2.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            // 
            // ProductCodeBox
            // 
            ProductCodeBox.Anchor = AnchorStyles.None;
            ProductCodeBox.BackColor = Color.FromArgb(24, 30, 46);
            ProductCodeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductCodeBox.ForeColor = Color.White;
            ProductCodeBox.Location = new Point(1223, 164);
            ProductCodeBox.Name = "ProductCodeBox";
            ProductCodeBox.RightToLeft = RightToLeft.Yes;
            ProductCodeBox.Size = new Size(229, 34);
            ProductCodeBox.TabIndex = 138;
            // 
            // ColorBox
            // 
            ColorBox.Anchor = AnchorStyles.None;
            ColorBox.BackColor = Color.FromArgb(24, 30, 46);
            ColorBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ColorBox.ForeColor = Color.White;
            ColorBox.Location = new Point(1223, 256);
            ColorBox.Name = "ColorBox";
            ColorBox.RightToLeft = RightToLeft.Yes;
            ColorBox.Size = new Size(229, 34);
            ColorBox.TabIndex = 139;
            // 
            // productID
            // 
            productID.Anchor = AnchorStyles.None;
            productID.BackColor = Color.FromArgb(24, 30, 46);
            productID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            productID.ForeColor = Color.White;
            productID.Location = new Point(305, 56);
            productID.Name = "productID";
            productID.RightToLeft = RightToLeft.Yes;
            productID.Size = new Size(115, 39);
            productID.TabIndex = 173;
            productID.Visible = false;
            // 
            // ok
            // 
            ok.Anchor = AnchorStyles.None;
            ok.BackColor = Color.LimeGreen;
            ok.FlatStyle = FlatStyle.Flat;
            ok.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            ok.ForeColor = Color.White;
            ok.Location = new Point(1066, 53);
            ok.Name = "ok";
            ok.Size = new Size(117, 44);
            ok.TabIndex = 174;
            ok.Text = "بحث";
            ok.UseVisualStyleBackColor = false;
            ok.Click += ok_Click;
            // 
            // Items
            // 
            Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Items.BackgroundColor = Color.White;
            Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items.Location = new Point(55, 350);
            Items.Name = "Items";
            Items.RightToLeft = RightToLeft.Yes;
            Items.RowHeadersWidth = 51;
            Items.RowTemplate.Height = 29;
            Items.Size = new Size(1388, 266);
            Items.TabIndex = 175;
            Items.RowHeaderMouseClick += Items_RowHeaderMouseClick;
            // 
            // SizeBox
            // 
            SizeBox.Anchor = AnchorStyles.None;
            SizeBox.BackColor = Color.FromArgb(24, 30, 46);
            SizeBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SizeBox.ForeColor = Color.White;
            SizeBox.FormattingEnabled = true;
            SizeBox.Items.AddRange(new object[] { "Small", "Medium", "Large", "XLarge", "XXLarge", "XXXLarge", "Custom" });
            SizeBox.Location = new Point(911, 243);
            SizeBox.Name = "SizeBox";
            SizeBox.RightToLeft = RightToLeft.Yes;
            SizeBox.Size = new Size(298, 49);
            SizeBox.TabIndex = 178;
            // 
            // ReturnedItemsGridview
            // 
            ReturnedItemsGridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReturnedItemsGridview.BackgroundColor = Color.White;
            ReturnedItemsGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReturnedItemsGridview.Columns.AddRange(new DataGridViewColumn[] { _Name, _barcode, _Size, _Color, _Quantity, _Category, _discount, _ReturnedID, _ProductID });
            ReturnedItemsGridview.Location = new Point(55, 648);
            ReturnedItemsGridview.Name = "ReturnedItemsGridview";
            ReturnedItemsGridview.RightToLeft = RightToLeft.Yes;
            ReturnedItemsGridview.RowHeadersWidth = 51;
            ReturnedItemsGridview.RowTemplate.Height = 29;
            ReturnedItemsGridview.Size = new Size(1388, 231);
            ReturnedItemsGridview.TabIndex = 179;
            // 
            // _Name
            // 
            _Name.HeaderText = "إسم المنتج";
            _Name.MinimumWidth = 6;
            _Name.Name = "_Name";
            // 
            // _barcode
            // 
            _barcode.HeaderText = "باركود الممنتج";
            _barcode.MinimumWidth = 6;
            _barcode.Name = "_barcode";
            // 
            // _Size
            // 
            _Size.HeaderText = "المقاس";
            _Size.MinimumWidth = 6;
            _Size.Name = "_Size";
            // 
            // _Color
            // 
            _Color.HeaderText = "اللون";
            _Color.MinimumWidth = 6;
            _Color.Name = "_Color";
            // 
            // _Quantity
            // 
            _Quantity.HeaderText = "الكمية";
            _Quantity.MinimumWidth = 6;
            _Quantity.Name = "_Quantity";
            // 
            // _Category
            // 
            _Category.HeaderText = "التصنيف";
            _Category.MinimumWidth = 6;
            _Category.Name = "_Category";
            // 
            // _discount
            // 
            _discount.HeaderText = "الخصم";
            _discount.MinimumWidth = 6;
            _discount.Name = "_discount";
            // 
            // _ReturnedID
            // 
            _ReturnedID.HeaderText = "كود المرتجع";
            _ReturnedID.MinimumWidth = 6;
            _ReturnedID.Name = "_ReturnedID";
            _ReturnedID.Visible = false;
            // 
            // _ProductID
            // 
            _ProductID.HeaderText = "كودالمنتج";
            _ProductID.MinimumWidth = 6;
            _ProductID.Name = "_ProductID";
            _ProductID.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1338, 324);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 180;
            label4.Text = "عناصر الفاتورة";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1359, 621);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 181;
            label9.Text = "المرتجعات";
            // 
            // ReturnedID
            // 
            ReturnedID.Anchor = AnchorStyles.None;
            ReturnedID.BackColor = Color.FromArgb(24, 30, 46);
            ReturnedID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnedID.ForeColor = Color.White;
            ReturnedID.Location = new Point(176, 53);
            ReturnedID.Name = "ReturnedID";
            ReturnedID.RightToLeft = RightToLeft.Yes;
            ReturnedID.Size = new Size(115, 39);
            ReturnedID.TabIndex = 182;
            ReturnedID.Visible = false;
            // 
            // CatComboBox
            // 
            CatComboBox.Anchor = AnchorStyles.None;
            CatComboBox.BackColor = Color.FromArgb(24, 30, 46);
            CatComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CatComboBox.ForeColor = Color.White;
            CatComboBox.Location = new Point(582, 164);
            CatComboBox.Name = "CatComboBox";
            CatComboBox.RightToLeft = RightToLeft.Yes;
            CatComboBox.Size = new Size(268, 34);
            CatComboBox.TabIndex = 183;
            // 
            // DeleteitemBtn
            // 
            DeleteitemBtn.Anchor = AnchorStyles.None;
            DeleteitemBtn.BackColor = Color.LimeGreen;
            DeleteitemBtn.FlatStyle = FlatStyle.Flat;
            DeleteitemBtn.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteitemBtn.ForeColor = Color.White;
            DeleteitemBtn.Location = new Point(338, 888);
            DeleteitemBtn.Name = "DeleteitemBtn";
            DeleteitemBtn.Size = new Size(264, 49);
            DeleteitemBtn.TabIndex = 184;
            DeleteitemBtn.Text = "حذف المنتج من الفاتورة";
            DeleteitemBtn.UseVisualStyleBackColor = false;
            DeleteitemBtn.Click += DeleteitemBtn_Click;
            // 
            // ReturnedItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(DeleteitemBtn);
            Controls.Add(CatComboBox);
            Controls.Add(ReturnedID);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(ReturnedItemsGridview);
            Controls.Add(label12);
            Controls.Add(SizeBox);
            Controls.Add(Items);
            Controls.Add(ok);
            Controls.Add(productID);
            Controls.Add(ColorBox);
            Controls.Add(panel2);
            Controls.Add(Addbtn);
            Controls.Add(Savebtn);
            Controls.Add(label14);
            Controls.Add(NotesBox);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(_discountBox);
            Controls.Add(label8);
            Controls.Add(QuantityBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ProductnameBox);
            Controls.Add(label5);
            Controls.Add(ProductCodeBox);
            Controls.Add(label2);
            Controls.Add(BillCodeBox);
            Controls.Add(panel1);
            MinimumSize = new Size(1496, 949);
            Name = "ReturnedItems";
            Size = new Size(1496, 949);
            Load += ReturnedItems_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReturnedItemsGridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button Addbtn;
        private Button Savebtn;
        private Label label14;
        private TextBox NotesBox;
        private Label label12;
        private Label label13;
        private Label label11;
        private TextBox _discountBox;
        private Label label8;
        private TextBox QuantityBox;
        private Label label7;
        private Label label6;
        private TextBox ProductnameBox;
        private Label label5;
        private Label label2;
        private TextBox BillCodeBox;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox ProductCodeBox;
        private TextBox ColorBox;
        private TextBox productID;
        private Button ok;
        private DataGridView Items;
        private ComboBox SizeBox;
        private DataGridView ReturnedItemsGridview;
        private Label label4;
        private Label label9;
        private TextBox ReturnedID;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn _barcode;
        private DataGridViewTextBoxColumn _Size;
        private DataGridViewTextBoxColumn _Color;
        private DataGridViewTextBoxColumn _Quantity;
        private DataGridViewTextBoxColumn _Category;
        private DataGridViewTextBoxColumn _discount;
        private DataGridViewTextBoxColumn _ReturnedID;
        private DataGridViewTextBoxColumn _ProductID;
        private TextBox CatComboBox;
        private Button DeleteitemBtn;
    }
}
