using System.ComponentModel;

namespace Store_System.UI
{
    partial class AddUserPage
    {
        private System.ComponentModel.IContainer components = null;



        /// <summary> 
        /// Required designer variable.
        /// </summary>

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AddUserPage));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            saveUserBtn = new Button();
            stockNameLbl = new Label();
            userRoleLbl = new Label();
            passwordLbl = new Label();
            userName = new Label();
            userMailLbl = new Label();
            userPhoneLbl = new Label();
            userNameLbl = new Label();
            stockNameBox = new TextBox();
            userMailBox = new TextBox();
            userPhoneBox = new TextBox();
            passwordBox = new TextBox();
            nameUserBox = new TextBox();
            userNameBox = new TextBox();
            panel5 = new Panel();
            existUserLbl = new Label();
            existUsrsGridView = new DataGridView();
            _Name = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            _username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            StockName = new DataGridViewTextBoxColumn();
            usersPic = new PictureBox();
            searchUserBox = new TextBox();
            saerchUserLbl = new Label();
            pictureBox2 = new PictureBox();
            deleteUserBtn = new Button();
            UserRoleBox = new ComboBox();
            nameerrore = new Label();
            usernameerror = new Label();
            passerror = new Label();
            stockerror = new Label();
            roleerror = new Label();
            updatebtm = new Button();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((ISupportInitialize)existUsrsGridView).BeginInit();
            ((ISupportInitialize)usersPic).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(250, 38);
            label1.TabIndex = 0;
            label1.Text = "إضافة مستخدم جديد";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1366, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(27, 156, 133);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1098, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 68);
            panel1.TabIndex = 2;
            // 
            // saveUserBtn
            // 
            saveUserBtn.Anchor = AnchorStyles.None;
            saveUserBtn.BackColor = Color.LimeGreen;
            saveUserBtn.FlatStyle = FlatStyle.Flat;
            saveUserBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveUserBtn.ForeColor = Color.White;
            saveUserBtn.Location = new Point(134, 415);
            saveUserBtn.Name = "saveUserBtn";
            saveUserBtn.Size = new Size(120, 57);
            saveUserBtn.TabIndex = 19;
            saveUserBtn.Text = "حفظ";
            saveUserBtn.UseVisualStyleBackColor = false;
            saveUserBtn.Click += saveUserBtn_Click;
            // 
            // stockNameLbl
            // 
            stockNameLbl.Anchor = AnchorStyles.None;
            stockNameLbl.AutoSize = true;
            stockNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            stockNameLbl.ForeColor = Color.White;
            stockNameLbl.Location = new Point(682, 274);
            stockNameLbl.Name = "stockNameLbl";
            stockNameLbl.Size = new Size(84, 23);
            stockNameLbl.TabIndex = 18;
            stockNameLbl.Text = "اسم الخزنة";
            // 
            // userRoleLbl
            // 
            userRoleLbl.Anchor = AnchorStyles.None;
            userRoleLbl.AutoSize = true;
            userRoleLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userRoleLbl.ForeColor = Color.White;
            userRoleLbl.Location = new Point(984, 272);
            userRoleLbl.Name = "userRoleLbl";
            userRoleLbl.Size = new Size(109, 23);
            userRoleLbl.TabIndex = 17;
            userRoleLbl.Text = "دور المستخدم";
            // 
            // passwordLbl
            // 
            passwordLbl.Anchor = AnchorStyles.None;
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLbl.ForeColor = Color.White;
            passwordLbl.Location = new Point(1323, 272);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(91, 23);
            passwordLbl.TabIndex = 16;
            passwordLbl.Text = "كلمة المرور";
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.None;
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userName.ForeColor = Color.White;
            userName.Location = new Point(299, 164);
            userName.Name = "userName";
            userName.Size = new Size(75, 23);
            userName.TabIndex = 15;
            userName.Text = "اليوزر نيم";
            // 
            // userMailLbl
            // 
            userMailLbl.Anchor = AnchorStyles.None;
            userMailLbl.AutoSize = true;
            userMailLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userMailLbl.ForeColor = Color.White;
            userMailLbl.Location = new Point(648, 164);
            userMailLbl.Name = "userMailLbl";
            userMailLbl.Size = new Size(57, 23);
            userMailLbl.TabIndex = 14;
            userMailLbl.Text = "الايميل";
            // 
            // userPhoneLbl
            // 
            userPhoneLbl.Anchor = AnchorStyles.None;
            userPhoneLbl.AutoSize = true;
            userPhoneLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userPhoneLbl.ForeColor = Color.White;
            userPhoneLbl.Location = new Point(1007, 164);
            userPhoneLbl.Name = "userPhoneLbl";
            userPhoneLbl.Size = new Size(86, 23);
            userPhoneLbl.TabIndex = 13;
            userPhoneLbl.Text = "رقم الهاتف";
            // 
            // userNameLbl
            // 
            userNameLbl.Anchor = AnchorStyles.None;
            userNameLbl.AutoSize = true;
            userNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLbl.ForeColor = Color.White;
            userNameLbl.Location = new Point(1291, 164);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(112, 23);
            userNameLbl.TabIndex = 12;
            userNameLbl.Text = "اسم المستخدم";
            // 
            // stockNameBox
            // 
            stockNameBox.Anchor = AnchorStyles.None;
            stockNameBox.BackColor = Color.FromArgb(24, 30, 46);
            stockNameBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            stockNameBox.ForeColor = Color.White;
            stockNameBox.Location = new Point(392, 290);
            stockNameBox.Name = "stockNameBox";
            stockNameBox.RightToLeft = RightToLeft.Yes;
            stockNameBox.Size = new Size(373, 47);
            stockNameBox.TabIndex = 11;
            // 
            // userMailBox
            // 
            userMailBox.Anchor = AnchorStyles.None;
            userMailBox.BackColor = Color.FromArgb(24, 30, 46);
            userMailBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userMailBox.ForeColor = Color.White;
            userMailBox.Location = new Point(398, 182);
            userMailBox.Name = "userMailBox";
            userMailBox.RightToLeft = RightToLeft.Yes;
            userMailBox.Size = new Size(367, 47);
            userMailBox.TabIndex = 10;
            // 
            // userPhoneBox
            // 
            userPhoneBox.Anchor = AnchorStyles.None;
            userPhoneBox.BackColor = Color.FromArgb(24, 30, 46);
            userPhoneBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userPhoneBox.ForeColor = Color.White;
            userPhoneBox.Location = new Point(782, 182);
            userPhoneBox.Name = "userPhoneBox";
            userPhoneBox.RightToLeft = RightToLeft.Yes;
            userPhoneBox.Size = new Size(313, 47);
            userPhoneBox.TabIndex = 8;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.None;
            passwordBox.BackColor = Color.FromArgb(24, 30, 46);
            passwordBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.ForeColor = Color.White;
            passwordBox.Location = new Point(1118, 290);
            passwordBox.Name = "passwordBox";
            passwordBox.RightToLeft = RightToLeft.Yes;
            passwordBox.Size = new Size(297, 47);
            passwordBox.TabIndex = 7;
            // 
            // nameUserBox
            // 
            nameUserBox.Anchor = AnchorStyles.None;
            nameUserBox.BackColor = Color.FromArgb(24, 30, 46);
            nameUserBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameUserBox.ForeColor = Color.White;
            nameUserBox.Location = new Point(1118, 182);
            nameUserBox.Name = "nameUserBox";
            nameUserBox.RightToLeft = RightToLeft.Yes;
            nameUserBox.Size = new Size(297, 47);
            nameUserBox.TabIndex = 6;
            // 
            // userNameBox
            // 
            userNameBox.Anchor = AnchorStyles.None;
            userNameBox.BackColor = Color.FromArgb(24, 30, 46);
            userNameBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userNameBox.ForeColor = Color.White;
            userNameBox.Location = new Point(85, 182);
            userNameBox.Name = "userNameBox";
            userNameBox.RightToLeft = RightToLeft.Yes;
            userNameBox.Size = new Size(296, 47);
            userNameBox.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(27, 156, 133);
            panel5.Controls.Add(existUserLbl);
            panel5.Location = new Point(1088, 408);
            panel5.Name = "panel5";
            panel5.Size = new Size(253, 57);
            panel5.TabIndex = 4;
            // 
            // existUserLbl
            // 
            existUserLbl.Anchor = AnchorStyles.None;
            existUserLbl.AutoSize = true;
            existUserLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            existUserLbl.ForeColor = Color.Snow;
            existUserLbl.Location = new Point(8, 10);
            existUserLbl.Name = "existUserLbl";
            existUserLbl.Size = new Size(242, 31);
            existUserLbl.TabIndex = 0;
            existUserLbl.Text = "المستخدمون الموجودون";
            // 
            // existUsrsGridView
            // 
            existUsrsGridView.Anchor = AnchorStyles.None;
            existUsrsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            existUsrsGridView.BackgroundColor = Color.Snow;
            existUsrsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            existUsrsGridView.Columns.AddRange(new DataGridViewColumn[] { _Name, phone, Email, _username, Password, Role, StockName });
            existUsrsGridView.Location = new Point(16, 488);
            existUsrsGridView.Name = "existUsrsGridView";
            existUsrsGridView.RightToLeft = RightToLeft.Yes;
            existUsrsGridView.RowHeadersWidth = 51;
            existUsrsGridView.RowTemplate.Height = 29;
            existUsrsGridView.Size = new Size(1460, 447);
            existUsrsGridView.TabIndex = 6;
            existUsrsGridView.RowHeaderMouseClick += existUsrsGridView_RowHeaderMouseClick;
            // 
            // _Name
            // 
            _Name.HeaderText = "الاسم";
            _Name.MinimumWidth = 6;
            _Name.Name = "_Name";
            // 
            // phone
            // 
            phone.HeaderText = "رقم الهاتف";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            // 
            // Email
            // 
            Email.HeaderText = "الايميل";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // _username
            // 
            _username.HeaderText = "اسم المستخدم";
            _username.MinimumWidth = 6;
            _username.Name = "_username";
            // 
            // Password
            // 
            Password.HeaderText = "كلمة المرور";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // Role
            // 
            Role.HeaderText = "الصلاحية";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            // 
            // StockName
            // 
            StockName.HeaderText = "إسم الخزنة";
            StockName.MinimumWidth = 6;
            StockName.Name = "StockName";
            // 
            // usersPic
            // 
            usersPic.Anchor = AnchorStyles.None;
            usersPic.BackColor = Color.FromArgb(24, 30, 46);
            usersPic.Image = (Image)resources.GetObject("usersPic.Image");
            usersPic.Location = new Point(1353, 408);
            usersPic.Name = "usersPic";
            usersPic.Size = new Size(62, 57);
            usersPic.SizeMode = PictureBoxSizeMode.Zoom;
            usersPic.TabIndex = 20;
            usersPic.TabStop = false;
            // 
            // searchUserBox
            // 
            searchUserBox.Anchor = AnchorStyles.None;
            searchUserBox.BackColor = Color.FromArgb(24, 30, 46);
            searchUserBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            searchUserBox.ForeColor = Color.White;
            searchUserBox.Location = new Point(501, 427);
            searchUserBox.Name = "searchUserBox";
            searchUserBox.RightToLeft = RightToLeft.Yes;
            searchUserBox.Size = new Size(362, 38);
            searchUserBox.TabIndex = 21;
            searchUserBox.TextChanged += searchUserBox_TextChanged;
            // 
            // saerchUserLbl
            // 
            saerchUserLbl.Anchor = AnchorStyles.None;
            saerchUserLbl.AutoSize = true;
            saerchUserLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            saerchUserLbl.ForeColor = Color.White;
            saerchUserLbl.Location = new Point(766, 408);
            saerchUserLbl.Name = "saerchUserLbl";
            saerchUserLbl.Size = new Size(95, 23);
            saerchUserLbl.TabIndex = 22;
            saerchUserLbl.Text = "ابحث بالاسم";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(869, 427);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.Anchor = AnchorStyles.None;
            deleteUserBtn.BackColor = Color.Firebrick;
            deleteUserBtn.FlatStyle = FlatStyle.Flat;
            deleteUserBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteUserBtn.ForeColor = Color.White;
            deleteUserBtn.Location = new Point(16, 415);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.Size = new Size(105, 57);
            deleteUserBtn.TabIndex = 24;
            deleteUserBtn.Text = "حذف";
            deleteUserBtn.UseVisualStyleBackColor = false;
            deleteUserBtn.Click += deleteUserBtn_Click;
            // 
            // UserRoleBox
            // 
            UserRoleBox.Anchor = AnchorStyles.None;
            UserRoleBox.BackColor = Color.FromArgb(24, 30, 46);
            UserRoleBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UserRoleBox.ForeColor = Color.White;
            UserRoleBox.FormattingEnabled = true;
            UserRoleBox.Items.AddRange(new object[] { "Admin", "Cashier" });
            UserRoleBox.Location = new Point(782, 290);
            UserRoleBox.Name = "UserRoleBox";
            UserRoleBox.RightToLeft = RightToLeft.Yes;
            UserRoleBox.Size = new Size(313, 49);
            UserRoleBox.TabIndex = 25;
            // 
            // nameerrore
            // 
            nameerrore.Anchor = AnchorStyles.None;
            nameerrore.AutoSize = true;
            nameerrore.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            nameerrore.ForeColor = Color.Red;
            nameerrore.Location = new Point(1178, 232);
            nameerrore.Name = "nameerrore";
            nameerrore.Size = new Size(210, 23);
            nameerrore.TabIndex = 26;
            nameerrore.Text = "لا يمكنك ترك هذا الحقل فارغ";
            nameerrore.Visible = false;
            // 
            // usernameerror
            // 
            usernameerror.Anchor = AnchorStyles.None;
            usernameerror.AutoSize = true;
            usernameerror.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            usernameerror.ForeColor = Color.Red;
            usernameerror.Location = new Point(134, 232);
            usernameerror.Name = "usernameerror";
            usernameerror.Size = new Size(210, 23);
            usernameerror.TabIndex = 27;
            usernameerror.Text = "لا يمكنك ترك هذا الحقل فارغ";
            usernameerror.Visible = false;
            // 
            // passerror
            // 
            passerror.Anchor = AnchorStyles.None;
            passerror.AutoSize = true;
            passerror.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            passerror.ForeColor = Color.Red;
            passerror.Location = new Point(1178, 340);
            passerror.Name = "passerror";
            passerror.Size = new Size(210, 23);
            passerror.TabIndex = 28;
            passerror.Text = "لا يمكنك ترك هذا الحقل فارغ";
            passerror.Visible = false;
            // 
            // stockerror
            // 
            stockerror.Anchor = AnchorStyles.None;
            stockerror.AutoSize = true;
            stockerror.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            stockerror.ForeColor = Color.Red;
            stockerror.Location = new Point(479, 340);
            stockerror.Name = "stockerror";
            stockerror.Size = new Size(210, 23);
            stockerror.TabIndex = 29;
            stockerror.Text = "لا يمكنك ترك هذا الحقل فارغ";
            stockerror.Visible = false;
            // 
            // roleerror
            // 
            roleerror.Anchor = AnchorStyles.None;
            roleerror.AutoSize = true;
            roleerror.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            roleerror.ForeColor = Color.Red;
            roleerror.Location = new Point(845, 343);
            roleerror.Name = "roleerror";
            roleerror.Size = new Size(210, 23);
            roleerror.TabIndex = 30;
            roleerror.Text = "لا يمكنك ترك هذا الحقل فارغ";
            roleerror.Visible = false;
            // 
            // updatebtm
            // 
            updatebtm.Anchor = AnchorStyles.None;
            updatebtm.BackColor = Color.LimeGreen;
            updatebtm.FlatStyle = FlatStyle.Flat;
            updatebtm.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            updatebtm.ForeColor = Color.White;
            updatebtm.Location = new Point(266, 415);
            updatebtm.Name = "updatebtm";
            updatebtm.Size = new Size(120, 57);
            updatebtm.TabIndex = 31;
            updatebtm.Text = "تعديل";
            updatebtm.UseVisualStyleBackColor = false;
            updatebtm.Click += updatebtn_Click;
            // 
            // AddUserPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(updatebtm);
            Controls.Add(roleerror);
            Controls.Add(stockerror);
            Controls.Add(passerror);
            Controls.Add(usernameerror);
            Controls.Add(nameerrore);
            Controls.Add(userRoleLbl);
            Controls.Add(UserRoleBox);
            Controls.Add(deleteUserBtn);
            Controls.Add(pictureBox2);
            Controls.Add(saerchUserLbl);
            Controls.Add(searchUserBox);
            Controls.Add(usersPic);
            Controls.Add(saveUserBtn);
            Controls.Add(pictureBox1);
            Controls.Add(stockNameLbl);
            Controls.Add(existUsrsGridView);
            Controls.Add(passwordLbl);
            Controls.Add(userName);
            Controls.Add(userMailLbl);
            Controls.Add(panel5);
            Controls.Add(userPhoneLbl);
            Controls.Add(panel1);
            Controls.Add(userNameLbl);
            Controls.Add(nameUserBox);
            Controls.Add(stockNameBox);
            Controls.Add(userNameBox);
            Controls.Add(userMailBox);
            Controls.Add(passwordBox);
            Controls.Add(userPhoneBox);
            MinimumSize = new Size(1496, 949);
            Name = "AddUserPage";
            Size = new Size(1496, 949);
            Load += AddUserPage_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((ISupportInitialize)existUsrsGridView).EndInit();
            ((ISupportInitialize)usersPic).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label userPhoneLbl;
        private Label userNameLbl;
        private TextBox stockNameBox;
        private TextBox userMailBox;
        private TextBox userPhoneBox;
        private TextBox passwordBox;
        private TextBox nameUserBox;
        private TextBox userNameBox;
        private Label userMailLbl;
        private Label userRoleLbl;
        private Label passwordLbl;
        private Label userName;
        private Label stockNameLbl;
        private Button saveUserBtn;
        private Panel panel5;
        private Label existUserLbl;
        private DataGridView existUsrsGridView;
        private PictureBox usersPic;
        private TextBox searchUserBox;
        private Label saerchUserLbl;
        private PictureBox pictureBox2;
        private Button deleteUserBtn;
        private ComboBox UserRoleBox;
        private Label nameerrore;
        private Label usernameerror;
        private Label passerror;
        private Label stockerror;
        private Label roleerror;
        private Button updatebtm;
        private DataGridViewTextBoxColumn _Name;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn _username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn StockName;
    }
}
