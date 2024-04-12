using DevExpress.XtraReports.UI;
using Store_System.Data;
using Store_System.Models;
using Store_System.Services.ReportsService;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Store_System.UI.DevExpReports
{
    public partial class SalingReports : DevExpress.XtraReports.UI.XtraReport
    {
        SaleReportService _reportService;
        public SalingReports(string Name, IEnumerable<BindingOrdersAndItems> Data, int CountOrders, double TotalSumOrders)
        {
            InitializeComponent();
            _reportService = new SaleReportService();
            this.objectDataSource1.DataSource = Data;
            DataSource = Data;
            label1.Text = Name;
            TotalpriceSum.Text = TotalSumOrders.ToString();
            OrdersNum.Text = CountOrders.ToString();
            foreach (var item in Data)
            {
                BarcodeCell.Text = item.Barcode.ToString();
            }
        }
    }
}
