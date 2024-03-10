﻿namespace Store_System.UI
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
            mainStockGridView = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            searchStockLbl = new Label();
            searchStockBox = new TextBox();
            nameOrderBtn = new Button();
            label2 = new Label();
            categoryOrderBtn = new Button();
            supplierOrderBtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mainStockGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // mainStockGridView
            // 
            mainStockGridView.Anchor = AnchorStyles.None;
            mainStockGridView.BackgroundColor = Color.Snow;
            mainStockGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainStockGridView.Location = new Point(0, 252);
            mainStockGridView.Name = "mainStockGridView";
            mainStockGridView.RowHeadersWidth = 51;
            mainStockGridView.RowTemplate.Height = 29;
            mainStockGridView.Size = new Size(1496, 697);
            mainStockGridView.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1388, 25);
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
            panel1.Location = new Point(1178, 39);
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
            pictureBox2.Location = new Point(322, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
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
            searchStockLbl.Location = new Point(212, 42);
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
            searchStockBox.Location = new Point(77, 56);
            searchStockBox.Name = "searchStockBox";
            searchStockBox.RightToLeft = RightToLeft.Yes;
            searchStockBox.Size = new Size(239, 43);
            searchStockBox.TabIndex = 27;
            // 
            // nameOrderBtn
            // 
            nameOrderBtn.Anchor = AnchorStyles.None;
            nameOrderBtn.BackColor = Color.FromArgb(27, 156, 133);
            nameOrderBtn.FlatStyle = FlatStyle.Flat;
            nameOrderBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nameOrderBtn.ForeColor = Color.White;
            nameOrderBtn.Location = new Point(1145, 186);
            nameOrderBtn.Name = "nameOrderBtn";
            nameOrderBtn.Padding = new Padding(0, 0, 0, 8);
            nameOrderBtn.Size = new Size(128, 48);
            nameOrderBtn.TabIndex = 30;
            nameOrderBtn.Text = "الاسم";
            nameOrderBtn.TextAlign = ContentAlignment.MiddleRight;
            nameOrderBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1305, 190);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(132, 31);
            label2.TabIndex = 31;
            label2.Text = "ترتيب حسب:";
            // 
            // categoryOrderBtn
            // 
            categoryOrderBtn.Anchor = AnchorStyles.None;
            categoryOrderBtn.BackColor = Color.FromArgb(27, 156, 133);
            categoryOrderBtn.FlatStyle = FlatStyle.Flat;
            categoryOrderBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            categoryOrderBtn.ForeColor = Color.White;
            categoryOrderBtn.Location = new Point(954, 186);
            categoryOrderBtn.Name = "categoryOrderBtn";
            categoryOrderBtn.Padding = new Padding(0, 0, 0, 8);
            categoryOrderBtn.Size = new Size(128, 48);
            categoryOrderBtn.TabIndex = 32;
            categoryOrderBtn.Text = "النوع";
            categoryOrderBtn.TextAlign = ContentAlignment.MiddleRight;
            categoryOrderBtn.UseVisualStyleBackColor = false;
            // 
            // supplierOrderBtn
            // 
            supplierOrderBtn.Anchor = AnchorStyles.None;
            supplierOrderBtn.BackColor = Color.FromArgb(27, 156, 133);
            supplierOrderBtn.FlatStyle = FlatStyle.Flat;
            supplierOrderBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            supplierOrderBtn.ForeColor = Color.White;
            supplierOrderBtn.Location = new Point(763, 186);
            supplierOrderBtn.Name = "supplierOrderBtn";
            supplierOrderBtn.Padding = new Padding(0, 0, 0, 8);
            supplierOrderBtn.Size = new Size(128, 48);
            supplierOrderBtn.TabIndex = 33;
            supplierOrderBtn.Text = "المورد";
            supplierOrderBtn.TextAlign = ContentAlignment.MiddleRight;
            supplierOrderBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.FromArgb(24, 30, 46);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1436, 190);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = Color.FromArgb(27, 156, 133);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1156, 197);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackColor = Color.FromArgb(27, 156, 133);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(965, 197);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 36;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackColor = Color.FromArgb(27, 156, 133);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(773, 197);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 37;
            pictureBox6.TabStop = false;
            // 
            // MainStockPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 46);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(supplierOrderBtn);
            Controls.Add(categoryOrderBtn);
            Controls.Add(label2);
            Controls.Add(nameOrderBtn);
            Controls.Add(pictureBox2);
            Controls.Add(searchStockLbl);
            Controls.Add(searchStockBox);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(mainStockGridView);
            MinimumSize = new Size(1496, 949);
            Name = "MainStockPage";
            Size = new Size(1496, 949);
            Load += MainStockPage_Load;
            ((System.ComponentModel.ISupportInitialize)mainStockGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView mainStockGridView;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label searchStockLbl;
        private TextBox searchStockBox;
        private Button nameOrderBtn;
        private Label label2;
        private Button categoryOrderBtn;
        private Button supplierOrderBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}