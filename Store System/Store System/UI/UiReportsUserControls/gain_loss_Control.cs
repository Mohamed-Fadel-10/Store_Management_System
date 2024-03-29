using Store_System.Services.ReportsService;
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
    public partial class gain_loss_Control : UserControl
    {
        GainLossReportService _gainLossReportService;
        public gain_loss_Control()
        {
            InitializeComponent();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            _gainLossReportService = new GainLossReportService();

            double TotalSale = _gainLossReportService.TotalPriceSale(FromDate.Value, ToDate.Value);
            double TotalBuy = _gainLossReportService.TotalPriceBuy(FromDate.Value, ToDate.Value);
            double Gain = TotalSale - TotalBuy;
            double GainPrecentage = (Gain / TotalSale) * 100;
            TotalSaleing.Text = TotalSale.ToString();
            TotalBuying.Text = TotalBuy.ToString();
            gain.Text = Gain.ToString();
            double roundedGain = Math.Round(GainPrecentage, 2);
            gainPrecentage.Text = roundedGain + "%";

        }

        private void DayReport_Click(object sender, EventArgs e)
        {
            _gainLossReportService = new GainLossReportService();

            double TotalSale = _gainLossReportService.TotalPriceSaleDay();
            double TotalBuy = _gainLossReportService.TotalPriceBuyDay();
            double Gain = TotalSale - TotalBuy;
            double GainPrecentage = (Gain / TotalSale) * 100;
            TotalSaleing.Text = TotalSale.ToString();
            TotalBuying.Text = TotalBuy.ToString();
            gain.Text = Gain.ToString();
            double roundedGain = Math.Round(GainPrecentage, 2);
            gainPrecentage.Text = roundedGain + "%";
        }

        private void MonthReport_Click(object sender, EventArgs e)
        {
            _gainLossReportService = new GainLossReportService();

            double TotalSale = _gainLossReportService.TotalPriceSaleMonth();
            double TotalBuy = _gainLossReportService.TotalPriceBuyMonth();
            double Gain = TotalSale - TotalBuy;
            double GainPrecentage = (Gain / TotalSale) * 100;
            TotalSaleing.Text = TotalSale.ToString();
            TotalBuying.Text = TotalBuy.ToString();
            gain.Text = Gain.ToString();
            double roundedGain = Math.Round(GainPrecentage, 2);
            gainPrecentage.Text = roundedGain + "%";
        }

        private void YearReport_Click(object sender, EventArgs e)
        {
            _gainLossReportService = new GainLossReportService();

            double TotalSale = _gainLossReportService.TotalPriceSaleYear();
            double TotalBuy = _gainLossReportService.TotalPriceBuyYear();
            double Gain = TotalSale - TotalBuy;
            double GainPrecentage = (Gain / TotalSale) * 100;
            TotalSaleing.Text = TotalSale.ToString();
            TotalBuying.Text = TotalBuy.ToString();
            gain.Text = Gain.ToString();
            double roundedGain = Math.Round(GainPrecentage, 2);
            gainPrecentage.Text = roundedGain + "%";
        }
    }
}
