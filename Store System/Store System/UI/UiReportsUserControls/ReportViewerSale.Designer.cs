﻿namespace Store_System.UI.UiReportsUserControls
{
    partial class ReportViewerSale
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
            documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            SuspendLayout();
            // 
            // documentViewer1
            // 
            documentViewer1.Dock = DockStyle.Fill;
            documentViewer1.IsMetric = false;
            documentViewer1.Location = new Point(0, 0);
            documentViewer1.Margin = new Padding(4, 4, 4, 4);
            documentViewer1.Name = "documentViewer1";
            documentViewer1.Size = new Size(966, 772);
            documentViewer1.TabIndex = 0;
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 772);
            Controls.Add(documentViewer1);
            Name = "XtraForm1";
            Text = "XtraForm1";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
    }
}