using Store_System.Models;
using Store_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store_System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;


namespace Store_System.UI
{
    public partial class AddProductPage : UserControl
    {
        ProductService _productService;
        CategoryService _categoryService;
        SupplierService _supplierService;
        ProductsSuppliers _productsSuppliers;
        SuppliersProductsService _suppliersProductsService;

        Product _product;
        public AddProductPage()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();

            _product = new Product();
            _supplierService = new SupplierService();
            _productsSuppliers = new ProductsSuppliers();
            _suppliersProductsService = new SuppliersProductsService();
        }


        private async void AddProductPage_Load(object sender, EventArgs e)
        {
            var Suppliers = await _supplierService.GetAllSuppliers();
            SupplierComboBox.DataSource = Suppliers;
            SupplierComboBox.DisplayMember = "Name";
            SupplierComboBox.ValueMember = "ID";
            SupplierComboBox.SelectedIndex = -1;
            var Categories = await _categoryService.GetALlCategories();
            CatComboBox.DataSource = Categories;
            CatComboBox.DisplayMember = "Name";
            CatComboBox.ValueMember = "ID";
            CatComboBox.SelectedIndex = -1;
            SizeBox.SelectedIndex = -1;
            BindingToGridView();
            Items.ClearSelection();



        }


        private async void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (barCodeBox.Text != "" && productNameBox.Text != "" && CatComboBox.SelectedItem != null && costBox.Text != "" && sellingPriceBox.Text != "" && stockBox.Text != "" && discountBox.Text != "")
            {
                var CategoryID = CatComboBox.SelectedValue.ToString();

                _product.Barcode = barCodeBox.Text;
                _product.Name = productNameBox.Text;
                _product.Category_id = int.Parse(CategoryID);
                _product.Cost = double.Parse(costBox.Text);
                _product.SellingPrice = double.Parse(sellingPriceBox.Text);
                _product.StockAmount = int.Parse(stockBox.Text);
                _product.Description = noteBox.Text;
                _product.Color = ColorBox.Text;
                _product.Size = (Models.Size)Convert.ToInt32(SizeBox.SelectedIndex);
                _product.Discount = double.Parse(discountBox.Text);
                await _productService.AddProduct(_product);
                _productsSuppliers.Supplier_Id = (int)SupplierComboBox.SelectedValue;
                _productsSuppliers.product_Id = _product.ID;
                await _suppliersProductsService.addSuppliersforProducts(_productsSuppliers);
                MessageBox.Show("تمت إضافة العنصر بنجاح", "system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGridView();
                Clear();


            }
            else
            {
                MessageBox.Show("يرجى ملئ جميع الحقول بالبينات", "system", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        

        private async void updatebtn_Click(object sender, EventArgs e)
        {

            Product product = await _productService.GetProductByBarcode(barCodeBox.Text);

            if (product != null)
            {
                product.Barcode = barCodeBox.Text;
                product.Name = productNameBox.Text;
                product.Cost = double.Parse(costBox.Text);
                product.SellingPrice = double.Parse(sellingPriceBox.Text);
                product.StockAmount = int.Parse(stockBox.Text);
                product.Description = noteBox.Text;
                product.Category_id = int.Parse(CatComboBox.SelectedValue.ToString());
                product.Color = ColorBox.Text;
                if (SizeBox.SelectedIndex >= 0 && SizeBox.SelectedIndex <= (int)Models.Size.Custom)
                {
                    product.Size = (Models.Size)SizeBox.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("من فضلك قم إدخال مقاس صحيح", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                product.Discount = double.Parse(discountBox.Text);

                await _productService.UpdateProduct(product);
                MessageBox.Show("تم التعديل بنجاح", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGridView();
            }
            else
            {
                MessageBox.Show("يرجى تحديد باركود المنتج المراد تعديله من أسفل الجدول ", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void Items_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            barCodeBox.Text = Items.CurrentRow.Cells[0].Value.ToString();
            productNameBox.Text = Items.CurrentRow.Cells[1].Value.ToString();
            //   CatComboBox.Text = Items.CurrentRow.Cells[2].Value.ToString();
            stockBox.Text = Items.CurrentRow.Cells[4].Value.ToString();
            costBox.Text = Items.CurrentRow.Cells[5].Value.ToString();
            discountBox.Text = Items.CurrentRow.Cells[6].Value.ToString();
            sellingPriceBox.Text = Items.CurrentRow.Cells[7].Value.ToString();
            ColorBox.Text = Items.CurrentRow.Cells[8].Value.ToString();
            SizeBox.Text = Items.CurrentRow.Cells[9].Value.ToString();
            noteBox.Text = Items.CurrentRow.Cells[10].Value.ToString();

        }



        private async void BindingToGridView()
        {
            var Products = await _productService.GetAllProducts();
            Items.AutoGenerateColumns = false;
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
        }


        private void RefreshGridView()
        {
            StoreContext storeContext = new StoreContext();
            var Products = storeContext.Product.ToList();
            Items.DataSource = Products;
        }
        private void Clear()
        {
            barCodeBox.Clear();
            productNameBox.Clear();
            CatComboBox.Text = "";
            stockBox.Clear();
            costBox.Clear();
            discountBox.Clear();
            sellingPriceBox.Clear();
            ColorBox.Clear();
            SizeBox.Text = "";
            noteBox.Clear();

        }


        // سيبها هنهندلها بعدين عشان فيها مشكلة
        private void discountBox_TextChanged(object sender, EventArgs e)
        {
            //if (discountBox.Text == "")
            //{
            //    discountBox.Text = 0.ToString();
            //}
            //else
            //{
            //    double discount = double.Parse(discountBox.Text);
            //    double cost = double.Parse(costBox.Text);
            //    double sellingPrice = cost - (discount / 100) * cost;

            //    sellingPriceBox.Text = sellingPrice.ToString();
            //}

        }

        private async void searchProductBox_TextChanged(object sender, EventArgs e)
        {
            if (searchProductBox.Text == "")
            {
                RefreshGridView();
            }
            else
            {
                var Products = await _productService.Search(searchProductBox.Text);
                Items.DataSource = Products;
            }
        }
    }
}
