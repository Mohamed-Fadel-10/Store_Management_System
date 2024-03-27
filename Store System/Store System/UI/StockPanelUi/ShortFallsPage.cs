using Store_System.Data;
using Store_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System.UI
{
    public partial class ShortFallsPage : UserControl
    {
        ShortFallsPageService _shortFallsPageService;

        public ShortFallsPage()
        {
            InitializeComponent();
            _shortFallsPageService = new ShortFallsPageService();
        }

        private void Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ShortFallsPage_Load(object sender, EventArgs e)
        {
            Items.AutoGenerateColumns = false;
            var ShortsProducts = await _shortFallsPageService.GetAllShortFalls();
            Items.DataSource = ShortsProducts;
            Items.Columns["_Barcode"].DataPropertyName = "Barcode";
            Items.Columns["_Name"].DataPropertyName = "Name";
            Items.Columns["category"].DataPropertyName = "CategoryName";
            Items.Columns["Supplier"].DataPropertyName = "ProductsSuppliers";
            Items.Columns["_Quantity"].DataPropertyName = "StockAmount";
            Items.Columns["_cost"].DataPropertyName = "Cost";
            Items.Columns["_discount"].DataPropertyName = "Discount";
            Items.Columns["Sale"].DataPropertyName = "SellingPrice";
            Items.Columns["_color"].DataPropertyName = "Color";
            Items.Columns["_size"].DataPropertyName = "Size";
            Items.Columns["notes"].DataPropertyName = "Description";
            int ShortsNumber = await _shortFallsPageService.CountShorts();
            ShortsCount.Text = ShortsNumber.ToString();
        }
        private void RefreshGridView()
        {
            StoreContext storeContext = new StoreContext();
            var Products = storeContext.Product.Where(p=>p.StockAmount==0).ToList();
            Items.DataSource = Products;
        }
        private async void searchShortageBox_TextChanged(object sender, EventArgs e)
        {
            if (searchShortageBox.Text == "")
            {
                RefreshGridView();
            }
            else { 
            var Shortages = await _shortFallsPageService.Search(searchShortageBox.Text);
                Items.DataSource = Shortages;
            }
        }
    }
}
