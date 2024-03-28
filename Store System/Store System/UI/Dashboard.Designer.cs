namespace Store_System.UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            shiftLockBtn = new Button();
            returnedBillBtn = new Button();
            saleBillBtn = new Button();
            groupBox1 = new GroupBox();
            buyBillBtn = new Button();
            shortFallsBtn = new Button();
            mainStockBtn = new Button();
            groupBox2 = new GroupBox();
            addSupplierBtn = new Button();
            addProductBtn = new Button();
            addCategoryBtn = new Button();
            addUserBtn = new Button();
            ControlAdminGr = new GroupBox();
            addBranchBtn = new Button();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            profitLossBtn = new Button();
            expensReportBtn = new Button();
            buyReportBtn = new Button();
            saleReportBtn = new Button();
            backHomeBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            logOutBtn = new Button();
            pictureBox3 = new PictureBox();
            welcomePage1 = new WelcomePage();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ControlAdminGr.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // shiftLockBtn
            // 
            shiftLockBtn.BackColor = Color.White;
            shiftLockBtn.FlatStyle = FlatStyle.Flat;
            shiftLockBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            shiftLockBtn.ForeColor = Color.Black;
            shiftLockBtn.Location = new Point(36, 80);
            shiftLockBtn.Name = "shiftLockBtn";
            shiftLockBtn.Size = new Size(143, 41);
            shiftLockBtn.TabIndex = 3;
            shiftLockBtn.Text = "تقفيل شيفت";
            shiftLockBtn.UseVisualStyleBackColor = false;
            shiftLockBtn.Click += shiftLockBtn_Click;
            // 
            // returnedBillBtn
            // 
            returnedBillBtn.BackColor = Color.White;
            returnedBillBtn.FlatStyle = FlatStyle.Flat;
            returnedBillBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            returnedBillBtn.ForeColor = Color.Black;
            returnedBillBtn.Location = new Point(206, 80);
            returnedBillBtn.Name = "returnedBillBtn";
            returnedBillBtn.Size = new Size(152, 41);
            returnedBillBtn.TabIndex = 2;
            returnedBillBtn.Text = "مرتجع بيع";
            returnedBillBtn.UseVisualStyleBackColor = false;
            returnedBillBtn.Click += returnedBillBtn_Click;
            // 
            // saleBillBtn
            // 
            saleBillBtn.BackColor = Color.White;
            saleBillBtn.FlatStyle = FlatStyle.Flat;
            saleBillBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            saleBillBtn.ForeColor = Color.Black;
            saleBillBtn.Location = new Point(206, 27);
            saleBillBtn.Name = "saleBillBtn";
            saleBillBtn.Size = new Size(152, 41);
            saleBillBtn.TabIndex = 0;
            saleBillBtn.Text = "فاتورة بيع";
            saleBillBtn.UseVisualStyleBackColor = false;
            saleBillBtn.Click += saleBillBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(shiftLockBtn);
            groupBox1.Controls.Add(returnedBillBtn);
            groupBox1.Controls.Add(buyBillBtn);
            groupBox1.Controls.Add(saleBillBtn);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(16, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيع وشراء";
            // 
            // buyBillBtn
            // 
            buyBillBtn.BackColor = Color.White;
            buyBillBtn.FlatStyle = FlatStyle.Flat;
            buyBillBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buyBillBtn.ForeColor = Color.Black;
            buyBillBtn.Location = new Point(36, 27);
            buyBillBtn.Name = "buyBillBtn";
            buyBillBtn.Size = new Size(143, 41);
            buyBillBtn.TabIndex = 1;
            buyBillBtn.Text = "فاتورة شراء";
            buyBillBtn.UseVisualStyleBackColor = false;
            buyBillBtn.Click += buyBillBtn_Click;
            // 
            // shortFallsBtn
            // 
            shortFallsBtn.BackColor = Color.White;
            shortFallsBtn.FlatStyle = FlatStyle.Flat;
            shortFallsBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            shortFallsBtn.ForeColor = Color.Black;
            shortFallsBtn.Location = new Point(37, 75);
            shortFallsBtn.Name = "shortFallsBtn";
            shortFallsBtn.Size = new Size(321, 41);
            shortFallsBtn.TabIndex = 2;
            shortFallsBtn.Text = "جدول النواقص";
            shortFallsBtn.UseVisualStyleBackColor = false;
            shortFallsBtn.Click += shortFallsBtn_Click;
            // 
            // mainStockBtn
            // 
            mainStockBtn.BackColor = Color.White;
            mainStockBtn.FlatStyle = FlatStyle.Flat;
            mainStockBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            mainStockBtn.ForeColor = Color.Black;
            mainStockBtn.Location = new Point(37, 26);
            mainStockBtn.Name = "mainStockBtn";
            mainStockBtn.Size = new Size(321, 41);
            mainStockBtn.TabIndex = 1;
            mainStockBtn.Text = "المخزن الرئيسى";
            mainStockBtn.UseVisualStyleBackColor = false;
            mainStockBtn.Click += mainStockBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(shortFallsBtn);
            groupBox2.Controls.Add(mainStockBtn);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(16, 278);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 130);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "المخازن";
            // 
            // addSupplierBtn
            // 
            addSupplierBtn.BackColor = Color.White;
            addSupplierBtn.FlatStyle = FlatStyle.Flat;
            addSupplierBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addSupplierBtn.ForeColor = Color.Black;
            addSupplierBtn.Location = new Point(39, 171);
            addSupplierBtn.Name = "addSupplierBtn";
            addSupplierBtn.Size = new Size(320, 41);
            addSupplierBtn.TabIndex = 4;
            addSupplierBtn.Text = "إضافة وتعديل مورد";
            addSupplierBtn.UseVisualStyleBackColor = false;
            addSupplierBtn.Click += addSupplierBtn_Click;
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = Color.White;
            addProductBtn.FlatStyle = FlatStyle.Flat;
            addProductBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addProductBtn.ForeColor = Color.Black;
            addProductBtn.Location = new Point(37, 73);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(320, 41);
            addProductBtn.TabIndex = 3;
            addProductBtn.Text = "إضافة وتعديل منتج";
            addProductBtn.UseVisualStyleBackColor = false;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.BackColor = Color.White;
            addCategoryBtn.FlatStyle = FlatStyle.Flat;
            addCategoryBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addCategoryBtn.ForeColor = Color.Black;
            addCategoryBtn.Location = new Point(39, 122);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(320, 41);
            addCategoryBtn.TabIndex = 2;
            addCategoryBtn.Text = "إضافة وتعديل صنف";
            addCategoryBtn.UseVisualStyleBackColor = false;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // addUserBtn
            // 
            addUserBtn.BackColor = Color.White;
            addUserBtn.FlatStyle = FlatStyle.Flat;
            addUserBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addUserBtn.ForeColor = Color.Black;
            addUserBtn.Location = new Point(38, 24);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(320, 41);
            addUserBtn.TabIndex = 1;
            addUserBtn.Text = "إضافة وتعديل مستخدم";
            addUserBtn.UseVisualStyleBackColor = false;
            addUserBtn.Click += addUserBtn_Click;
            // 
            // ControlAdminGr
            // 
            ControlAdminGr.Controls.Add(addBranchBtn);
            ControlAdminGr.Controls.Add(addSupplierBtn);
            ControlAdminGr.Controls.Add(addProductBtn);
            ControlAdminGr.Controls.Add(addCategoryBtn);
            ControlAdminGr.Controls.Add(addUserBtn);
            ControlAdminGr.FlatStyle = FlatStyle.Flat;
            ControlAdminGr.ForeColor = Color.White;
            ControlAdminGr.Location = new Point(16, 666);
            ControlAdminGr.Name = "ControlAdminGr";
            ControlAdminGr.Size = new Size(391, 271);
            ControlAdminGr.TabIndex = 4;
            ControlAdminGr.TabStop = false;
            ControlAdminGr.Text = "التحكم";
            // 
            // addBranchBtn
            // 
            addBranchBtn.BackColor = Color.PaleGreen;
            addBranchBtn.FlatStyle = FlatStyle.Flat;
            addBranchBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addBranchBtn.ForeColor = Color.Black;
            addBranchBtn.Location = new Point(38, 220);
            addBranchBtn.Name = "addBranchBtn";
            addBranchBtn.Size = new Size(320, 41);
            addBranchBtn.TabIndex = 5;
            addBranchBtn.Text = "إضافة وتعديل فرع";
            addBranchBtn.UseVisualStyleBackColor = false;
            addBranchBtn.Click += addBranchBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(24, 30, 46);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(backHomeBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ControlAdminGr);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(1493, 48);
            panel1.MaximumSize = new Size(429, 952);
            panel1.MinimumSize = new Size(429, 952);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 952);
            panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(profitLossBtn);
            groupBox3.Controls.Add(expensReportBtn);
            groupBox3.Controls.Add(buyReportBtn);
            groupBox3.Controls.Add(saleReportBtn);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(18, 412);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(391, 252);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "التقارير";
            // 
            // profitLossBtn
            // 
            profitLossBtn.BackColor = Color.White;
            profitLossBtn.FlatStyle = FlatStyle.Flat;
            profitLossBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            profitLossBtn.ForeColor = Color.Black;
            profitLossBtn.Location = new Point(39, 193);
            profitLossBtn.Name = "profitLossBtn";
            profitLossBtn.Size = new Size(318, 41);
            profitLossBtn.TabIndex = 4;
            profitLossBtn.Text = " ربح وخسارة";
            profitLossBtn.UseVisualStyleBackColor = false;
            // 
            // expensReportBtn
            // 
            expensReportBtn.BackColor = Color.White;
            expensReportBtn.FlatStyle = FlatStyle.Flat;
            expensReportBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            expensReportBtn.ForeColor = Color.Black;
            expensReportBtn.Location = new Point(39, 141);
            expensReportBtn.Name = "expensReportBtn";
            expensReportBtn.Size = new Size(318, 41);
            expensReportBtn.TabIndex = 3;
            expensReportBtn.Text = "تقرير مصروفات";
            expensReportBtn.UseVisualStyleBackColor = false;
            // 
            // buyReportBtn
            // 
            buyReportBtn.BackColor = Color.White;
            buyReportBtn.FlatStyle = FlatStyle.Flat;
            buyReportBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buyReportBtn.ForeColor = Color.Black;
            buyReportBtn.Location = new Point(39, 92);
            buyReportBtn.Name = "buyReportBtn";
            buyReportBtn.Size = new Size(318, 41);
            buyReportBtn.TabIndex = 2;
            buyReportBtn.Text = "تقرير مشتريات";
            buyReportBtn.UseVisualStyleBackColor = false;
            buyReportBtn.Click += buyReportBtn_Click_1;
            // 
            // saleReportBtn
            // 
            saleReportBtn.BackColor = Color.White;
            saleReportBtn.FlatStyle = FlatStyle.Flat;
            saleReportBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            saleReportBtn.ForeColor = Color.Black;
            saleReportBtn.Location = new Point(39, 43);
            saleReportBtn.Name = "saleReportBtn";
            saleReportBtn.Size = new Size(318, 41);
            saleReportBtn.TabIndex = 1;
            saleReportBtn.Text = "تقرير مبيعات";
            saleReportBtn.UseVisualStyleBackColor = false;
            saleReportBtn.Click += saleReportBtn_Click_1;
            // 
            // backHomeBtn
            // 
            backHomeBtn.BackColor = Color.FromArgb(24, 30, 46);
            backHomeBtn.BackgroundImage = (Image)resources.GetObject("backHomeBtn.BackgroundImage");
            backHomeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            backHomeBtn.FlatAppearance.BorderSize = 0;
            backHomeBtn.FlatStyle = FlatStyle.Flat;
            backHomeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backHomeBtn.ForeColor = Color.White;
            backHomeBtn.Location = new Point(16, 39);
            backHomeBtn.Name = "backHomeBtn";
            backHomeBtn.Size = new Size(84, 62);
            backHomeBtn.TabIndex = 11;
            backHomeBtn.UseVisualStyleBackColor = false;
            backHomeBtn.Click += backHomeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(254, 51);
            label1.Name = "label1";
            label1.Size = new Size(66, 31);
            label1.TabIndex = 9;
            label1.Text = "الاسم";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 156, 133);
            panel2.Controls.Add(logOutBtn);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1919, 45);
            panel2.TabIndex = 2;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.Firebrick;
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logOutBtn.ForeColor = Color.White;
            logOutBtn.Location = new Point(78, 5);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(119, 35);
            logOutBtn.TabIndex = 10;
            logOutBtn.Text = "تسجيل الخروج";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // welcomePage1
            // 
            welcomePage1.BackColor = Color.FromArgb(24, 30, 46);
            welcomePage1.Location = new Point(-5, 51);
            welcomePage1.MinimumSize = new Size(1496, 949);
            welcomePage1.Name = "welcomePage1";
            welcomePage1.Size = new Size(1496, 949);
            welcomePage1.TabIndex = 13;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            ClientSize = new Size(1924, 1004);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(welcomePage1);
            MinimumSize = new Size(1918, 1028);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            FormClosed += AdminDashboard_FormClosed;
            Load += AdminDashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ControlAdminGr.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button shiftLockBtn;
        private Button returnedBillBtn;
        private Button saleBillBtn;
        private GroupBox groupBox1;
        private Button buyBillBtn;
        private Button shortFallsBtn;
        private Button mainStockBtn;
        private GroupBox groupBox2;
        private Button addSupplierBtn;
        private Button addProductBtn;
        private Button addCategoryBtn;
        private Button addUserBtn;
        private GroupBox ControlAdminGr;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button logOutBtn;
        private AddProductPage addProductPage1;
        private AddUserPage addUserPage1;
        private AddCategoryPage addCategoryPage1;
        private AddSupplierPage addSupplierPage1;
        private MainStockPage mainStockPage1;
        private ShortFallsPage shortFallsPage1;
        private PictureBox pictureBox3;
        private WelcomePage welcomePage1;
        private Button backHomeBtn;
        private ControlPanelUi.BuyBill buyBill1;
        private ControlPanelUi.SaleBill saleBill1;
        private ControlPanelUi.ReturnedItems returnedItems1;
        private ControlPanelUi.ShiftLock shiftLock1;
        private Button addBranchBtn;
        private GroupBox groupBox3;
        private Button profitLossBtn;
        private Button expensReportBtn;
        private Button buyReportBtn;
        private Button saleReportBtn;
    }
}