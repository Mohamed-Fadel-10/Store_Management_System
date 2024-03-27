using Store_System.Data;
using Store_System.Services.ReportsService;
using Store_System.UI.DevExpReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System.UI.UiReportsUserControls
{
    public partial class BuyReports : UserControl
    {
        BuyReportService _buyReportService;
        public BuyReports()
        {
            InitializeComponent();
            _buyReportService = new BuyReportService();
        }

        private void DayBuy_Click(object sender, EventArgs e)
        {
            _buyReportService = new BuyReportService();

            List<BindingOrdersAndItems> orderItems = _buyReportService.OneDayOrders();
            int orderCount = _buyReportService.CountOrdersDay();
            double TotalSumOrders = _buyReportService.TotalPriceDay();

            if (orderItems.Count > 0)
            {
                SalingReports report = new SalingReports("تقرير مشتريات اليوم", orderItems, orderCount, TotalSumOrders);
                ReportViewerSale reportViewerForm = new ReportViewerSale();
                reportViewerForm.DisplayReport(report);
                reportViewerForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("لا توجد مشتريات بتاريخ اليوم", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MonthBuy_Click(object sender, EventArgs e)
        {
            _buyReportService = new BuyReportService();

            List<BindingOrdersAndItems> orderItems = _buyReportService.MonthOrders();
            int orderCount = _buyReportService.CountOrdersMonth();
            double TotalSumOrders = _buyReportService.TotalPriceMonthe();

            if (orderItems.Count > 0)
            {
                SalingReports report = new SalingReports("تقرير مشتريات شهرى", orderItems, orderCount, TotalSumOrders);
                ReportViewerSale reportViewerForm = new ReportViewerSale();
                reportViewerForm.DisplayReport(report);
                reportViewerForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات للمعايير المحددة", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void YearBuy_Click(object sender, EventArgs e)
        {
            _buyReportService = new BuyReportService();

            List<BindingOrdersAndItems> orderItems = _buyReportService.YearOrders();
            int orderCount = _buyReportService.CountOrdersYear();
            double TotalSumOrders = _buyReportService.TotalPriceYear();

            if (orderItems.Count > 0)
            {
                SalingReports report = new SalingReports("تقرير مشتريات سنوى", orderItems, orderCount, TotalSumOrders);
                ReportViewerSale reportViewerForm = new ReportViewerSale();
                reportViewerForm.DisplayReport(report);
                reportViewerForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("لم يتم العثور على بيانات للمعايير المحددة", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FaturaBuy_Click(object sender, EventArgs e)
        {
            _buyReportService = new BuyReportService();
            if (orderNumber.Text == "")
            {
                MessageBox.Show("يرجى إدخال رقم الفاتورة اولا", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<BindingOrdersAndItems> orderItems = _buyReportService.CustomBill(int.Parse(orderNumber.Text));
                int orderCount = _buyReportService.CountOrdersCustom(int.Parse(orderNumber.Text));
                double TotalSumOrders = _buyReportService.TotalPriceCustom(int.Parse(orderNumber.Text));

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
