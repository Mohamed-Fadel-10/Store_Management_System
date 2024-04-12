using DevExpress.XtraReports.UI;
using Store_System.Data;
using Store_System.UI.ControlPanelUi;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace Store_System.UI.DevExpReports
{
    public partial class FaturaOrdrRpt : DevExpress.XtraReports.UI.XtraReport
    {
        public FaturaOrdrRpt(List<BindingOrdersAndItems> items, SaleBill saleBill)
        {
            InitializeComponent();

            billCode.Text = saleBill.BillCodeBox.Text;
            billDate.Text = DateTime.Now.ToString("yyyy/dd/MM");
            customerName.Text= saleBill.CustomerNameBox.Text;
            customerPhone.Text= saleBill.CustomerPhone.Text;
            StringBuilder productNames = new StringBuilder();
            StringBuilder productPrices = new StringBuilder();
            StringBuilder productQuantities = new StringBuilder();
            StringBuilder TotalPriceproduct = new StringBuilder();
            StringBuilder index = new StringBuilder();

            int count = 0;
            foreach (var item in items)
            {
                productNames.Append(item.ProductName + Environment.NewLine);
                productPrices.Append(item.Price + Environment.NewLine);
                productQuantities.Append(item.Quantity + Environment.NewLine);
                TotalPriceproduct.Append(item.ProductTotal + Environment.NewLine);
                count++;
                index.Append(count + Environment.NewLine);
               
            }

            productName.Text = productNames.ToString().Trim();
            productPrice.Text = productPrices.ToString().Trim();
            productQuantity.Text = productQuantities.ToString().Trim();
            productTotalPrice.Text = TotalPriceproduct.ToString().Trim();
            cellIndex.Text = index.ToString().Trim();

            quantity.Text = saleBill.totalQuantityBox.Text;
            totalPrice.Text=saleBill.TotalPriceBox.Text.ToString();
            discount.Text=saleBill.FaturaDiscountBox.Text.ToString();
            afterDiscount.Text=saleBill.AfterDiscount.Text.ToString();
            billPaid.Text=saleBill.PaidUp.Text.ToString();
            remaining.Text = "000.0";
            billBarCode.Text=billCode.Text.ToString();
            





        }

    }
}
