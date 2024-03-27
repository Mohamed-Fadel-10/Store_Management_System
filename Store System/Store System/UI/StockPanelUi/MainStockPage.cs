using Microsoft.EntityFrameworkCore;
using Store_System.Data;
using Store_System.Models;
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
    public partial class MainStockPage : UserControl
    {
        private readonly MainStockService _mainStockService;
        private readonly CategoryService _categoryService;
        public MainStockPage()
        {
            InitializeComponent();
            _mainStockService = new MainStockService();
            _categoryService = new CategoryService();
        }

        private async void MainStockPage_Load(object sender, EventArgs e)
        {
            Items.AutoGenerateColumns = false;
            var Products = await _mainStockService.GetAllProducts();
            Items.DataSource = Products;
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
            //-----------------------------------------
            List<Category> Categories = await _categoryService.GetALlCategories();
            CategoriesCombo.DataSource = Categories;
            CategoriesCombo.DisplayMember = "Name";
            CategoriesCombo.ValueMember = "ID";
            CategoriesCombo.SelectedIndex = -1;
            //-----------------------------------------
            int ShortsNumber = await _mainStockService.CountShorts();
            ShortsCount.Text = ShortsNumber.ToString();
            //-----------------------------------------
            int allProducts = await _mainStockService.CountsAll();
            AvailableProductsBox.Text = allProducts.ToString();
            //-----------------------------------------
            double TotalAmount = await _mainStockService.CountMoney();
            TotalStockSystem.Text = TotalAmount.ToString();
            //-----------------------------------------
            CategoriesCombo.SelectedIndex = 0;

        }
        private async void RefreshGridView()
        {
            StoreContext storeContext = new StoreContext();
            var Products = await storeContext.Product.ToListAsync();
            Items.DataSource = Products;
        }
        private async void ItemChoosecomb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemChoosecomb.SelectedIndex == 0)
            {
                var Products = await _mainStockService.GetAllProducts();
                Items.DataSource = Products;

            }
            else if (ItemChoosecomb.SelectedIndex == 1)
            {
                var Products = await _mainStockService.ProductsWillShorts();
                Items.DataSource = Products;
            }
        }

        private async void CategoriesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = CategoriesCombo.SelectedItem as Store_System.Models.Category;
            if (selectedCategory != null)
            {
                int CategoryID = selectedCategory.ID;
                List<Product> products = await _mainStockService.ProductsBasedOnCategory(CategoryID);
                Items.DataSource = products;
            }
        
        }
       
        private async void searchStockBox_TextChanged(object sender, EventArgs e)
        {
            if (searchStockBox.Text == "")
            {
                RefreshGridView();
            }
           List<Product> products= await _mainStockService.Search(searchStockBox.Text);
            Items.DataSource = products;
        }
    }
}
