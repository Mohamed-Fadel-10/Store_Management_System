using DevExpress.XtraReports.UI;
using Store_System.Data;
using Store_System.Models;
using Store_System.Services.ReportsService;
using Store_System.UI.DevExpReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace Store_System.UI.UiReportsUserControls
{
    public partial class SaleingReports : UserControl
    {
        SaleReportService _saleReportService;
        public SaleingReports()
        {
            InitializeComponent();
        }
        private void OpenPdfFile(string filePath)
        {
            try
            {
                // Use the default application associated with the PDF file extension
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                // Handle specific exception for access issues
                MessageBox.Show($"Error opening PDF file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"Error opening PDF file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DaySale_Click(object sender, EventArgs e)
        {
            _saleReportService = new SaleReportService();

            List<BindingOrdersAndItems> orderItems = _saleReportService.OneDayOrders();
            int orderCount = _saleReportService.CountOrdersDay();
            double TotalSumOrders = _saleReportService.TotalPriceDay();

            if (orderItems.Count > 0)
            {
                SalingReports report = new SalingReports("تقرير مبيعات اليوم", orderItems, orderCount, TotalSumOrders);
                ReportViewerSale reportViewerForm = new ReportViewerSale();
                reportViewerForm.DisplayReport(report);
                reportViewerForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات للمعايير المحددة", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void MonthSale_Click(object sender, EventArgs e)
        {
            _saleReportService = new SaleReportService();

            List<BindingOrdersAndItems> orderItems = _saleReportService.MonthOrders();
            int orderCount = _saleReportService.CountOrdersMonth();
            double TotalSumOrders = _saleReportService.TotalPriceMonthe();

            if (orderItems.Count > 0)
            {
                SalingReports report = new SalingReports("تقرير مبيعات شهرى", orderItems, orderCount, TotalSumOrders);
                ReportViewerSale reportViewerForm = new ReportViewerSale();
                reportViewerForm.DisplayReport(report);
                reportViewerForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات للمعايير المحددة", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void YearSale_Click(object sender, EventArgs e)
        {
            _saleReportService = new SaleReportService();

            List<BindingOrdersAndItems> orderItems = _saleReportService.YearOrders();
            int orderCount = _saleReportService.CountOrdersYear();
            double TotalSumOrders = _saleReportService.TotalPriceYear();

            if (orderItems.Count > 0)
            {
                SalingReports report = new SalingReports("تقرير مبيعات سنوى", orderItems, orderCount, TotalSumOrders);
                ReportViewerSale reportViewerForm = new ReportViewerSale();
                reportViewerForm.DisplayReport(report);
                reportViewerForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات للمعايير المحددة", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FaturaSale_Click(object sender, EventArgs e)
        {
            _saleReportService = new SaleReportService();
            if (orderNumber.Text == "")
            {
                MessageBox.Show("يرجى إدخال رقم الفاتورة اولا", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<BindingOrdersAndItems> orderItems = _saleReportService.CustomBill(int.Parse(orderNumber.Text));
                int orderCount = _saleReportService.CountOrdersCustom(int.Parse(orderNumber.Text));
                double TotalSumOrders = _saleReportService.TotalPriceCustom(int.Parse(orderNumber.Text));

                if (orderItems.Count > 0)
                {
                    SalingReports report = new SalingReports($"{orderNumber.Text} : تقرير فاتورة رقم  ", orderItems, orderCount, TotalSumOrders);
                    ReportViewerSale reportViewerForm = new ReportViewerSale();
                    reportViewerForm.DisplayReport(report);
                    reportViewerForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"{orderNumber.Text} : لا توجد فاتورة بيع بهذا الرقم ", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
