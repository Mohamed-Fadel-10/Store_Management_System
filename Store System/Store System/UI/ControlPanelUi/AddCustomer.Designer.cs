namespace Store_System.UI.ControlPanelUi
{
    partial class AddCustomer
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
            barCodeLbl = new Label();
            pNameLbl = new Label();
            _PhoneBox = new TextBox();
            _NameBox = new TextBox();
            AddClientBtn = new Button();
            SuspendLayout();
            // 
            // barCodeLbl
            // 
            barCodeLbl.Anchor = AnchorStyles.None;
            barCodeLbl.AutoSize = true;
            barCodeLbl.BackColor = Color.FromArgb(24, 30, 46);
            barCodeLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            barCodeLbl.ForeColor = Color.White;
            barCodeLbl.Location = new Point(688, 97);
            barCodeLbl.Name = "barCodeLbl";
            barCodeLbl.Padding = new Padding(0, 0, 0, 5);
            barCodeLbl.RightToLeft = RightToLeft.Yes;
            barCodeLbl.Size = new Size(48, 28);
            barCodeLbl.TabIndex = 19;
            barCodeLbl.Text = "ألاسم";
            // 
            // pNameLbl
            // 
            pNameLbl.Anchor = AnchorStyles.None;
            pNameLbl.AutoSize = true;
            pNameLbl.BackColor = Color.FromArgb(24, 30, 46);
            pNameLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            pNameLbl.ForeColor = Color.White;
            pNameLbl.Location = new Point(267, 97);
            pNameLbl.Name = "pNameLbl";
            pNameLbl.Padding = new Padding(0, 0, 0, 5);
            pNameLbl.RightToLeft = RightToLeft.Yes;
            pNameLbl.Size = new Size(97, 28);
            pNameLbl.TabIndex = 21;
            pNameLbl.Text = "رقم التليفون";
            // 
            // _PhoneBox
            // 
            _PhoneBox.Anchor = AnchorStyles.None;
            _PhoneBox.BackColor = Color.FromArgb(24, 30, 46);
            _PhoneBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            _PhoneBox.ForeColor = Color.White;
            _PhoneBox.Location = new Point(26, 120);
            _PhoneBox.Name = "_PhoneBox";
            _PhoneBox.Size = new Size(337, 47);
            _PhoneBox.TabIndex = 22;
            // 
            // _NameBox
            // 
            _NameBox.Anchor = AnchorStyles.None;
            _NameBox.BackColor = Color.FromArgb(24, 30, 46);
            _NameBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            _NameBox.ForeColor = Color.White;
            _NameBox.Location = new Point(394, 120);
            _NameBox.Name = "_NameBox";
            _NameBox.Size = new Size(342, 47);
            _NameBox.TabIndex = 20;
            // 
            // AddClientBtn
            // 
            AddClientBtn.Anchor = AnchorStyles.None;
            AddClientBtn.BackColor = Color.LimeGreen;
            AddClientBtn.FlatStyle = FlatStyle.Popup;
            AddClientBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AddClientBtn.ForeColor = Color.Snow;
            AddClientBtn.Location = new Point(288, 253);
            AddClientBtn.Name = "AddClientBtn";
            AddClientBtn.RightToLeft = RightToLeft.Yes;
            AddClientBtn.Size = new Size(153, 56);
            AddClientBtn.TabIndex = 23;
            AddClientBtn.Text = "إضافة";
            AddClientBtn.UseVisualStyleBackColor = false;
            AddClientBtn.Click += AddClientBtn_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            ClientSize = new Size(800, 588);
            Controls.Add(AddClientBtn);
            Controls.Add(barCodeLbl);
            Controls.Add(pNameLbl);
            Controls.Add(_PhoneBox);
            Controls.Add(_NameBox);
            Name = "AddCustomer";
            Text = "AddCustomer";
            FormClosed += AddCustomer_FormClosed;
            Load += AddCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label barCodeLbl;
        private Label pNameLbl;
        private TextBox _PhoneBox;
        private TextBox _NameBox;
        private Button AddClientBtn;
    }
}