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
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace Store_System.UI.ControlPanelUi
{
    public partial class BuyBill : UserControl
    {
        BuyBillService buyBillService;
        CategoryService categoryService;
        ProductService productService;
        Order order;
        SupplierService _supplierService;
        Dashboard adminDashboard;
        ProductsSuppliers _productsSuppliers;
        SuppliersProductsService _suppliersProductsService;

        private int branchID { get; set; }

        public BuyBill()
        {
            InitializeComponent();
            buyBillService = new BuyBillService();
            categoryService = new CategoryService();
            order = new Order();

            branchIdBox.Text = 1.ToString();
            _supplierService = new SupplierService();
            _productsSuppliers = new ProductsSuppliers();
            _suppliersProductsService = new SuppliersProductsService();
            productService = new ProductService();
        }

        private async void BuyBill_Load(object sender, EventArgs e)
        {
            var Suppliers = await _supplierService.GetAllSuppliers();
            SupplierBox.DataSource = Suppliers;
            SupplierBox.DisplayMember = "Name";
            SupplierBox.ValueMember = "ID";
            SupplierBox.SelectedIndex = -1;


            order = await buyBillService.GetLastOrderID();
            BillCodeBox.Text = (order.ID + 1).ToString(); // add one to last id to insert it ( 0 ==> 0 + 1 = 1 ) ههههه
            var Categories = await categoryService.GetALlCategories();
            ClassificationBox.DataSource = Categories;
            ClassificationBox.DisplayMember = "Name";
            ClassificationBox.ValueMember = "ID";
            ClassificationBox.SelectedIndex = -1;
            ProductCodeBox.Focus();
            Date.Text = DateTime.Now.ToString("yyyy/dd/MM");



        }

        private async void ProductCodeBox_TextChanged(object sender, EventArgs e)
        {
            string barcode = ProductCodeBox.Text;
            if (barcode != "")
            {
                try
                {
                    Product Product = await buyBillService.GetProductCode(barcode);

                    if (Product != null)
                    {
                        ProductIDBox.Text = Product.ID.ToString();
                        ProductCodeBox.Text = Product.Barcode;
                        ProductnameBox.Text = Product.Name;
                        ClassificationBox.Text = Product.Category.Name;
                        ColorBox.Text = Product.Color;
                        SizeBox.Text = Product.Size.ToString();
                        CostBox.Text = Product.Cost.ToString();
                        PriceBox.Text = Product.SellingPrice.ToString();
                        QuantityBox.Text = 1.ToString();
                        DiscountBox.Text = "";
                        // SupplierBox.DataSource = Product.ToList();
                    }
                    else
                    {
                        ProductnameBox.Clear();
                        ClassificationBox.Text = "";
                        QuantityBox.Clear();
                        ColorBox.Text = "";
                        SizeBox.Text = "";
                        PriceBox.Clear();
                        CostBox.Clear();
                        DiscountBox.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("يرجى إدخال باركود المنتج", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (DiscountBox.Text == "")
                    {
                        DiscountBox.Text = 0.ToString();
                    }
                    double Quantity = int.Parse(QuantityBox.Text);
                    double Price = double.Parse(PriceBox.Text);
                    double Discount = double.Parse(DiscountBox.Text);
                    double TotalPrice = Quantity * Price;
                    double afterDiscount = (TotalPrice * (1 - (Discount / 100)));
                    string formattedResult = afterDiscount.ToString("F3");
                    //================================================================
                    Order lastOrderID = await buyBillService.GetLastOrderID();


                    Items.Rows.Add(ProductCodeBox.Text, ProductnameBox.Text, ClassificationBox.Text, QuantityBox.Text, ColorBox.Text, SizeBox.Text, PriceBox.Text, DiscountBox.Text, formattedResult, NotesBox.Text, ProductIDBox.Text, ((lastOrderID.ID) + 1));



                    ///------------------------------------------------------
                    double sum = 0;
                    for (int i = 0; i < Items.Rows.Count - 1; ++i)
                    {
                        sum += double.Parse(Items.Rows[i].Cells[8].Value.ToString());
                    }
                    TotalPriceBox.Text = sum.ToString("F3");
                    AfterDiscount.Text = sum.ToString("F3");
                    PaidUp.Text = sum.ToString("F3");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن إضافة بيانات فارغة الى الفاتورة قم بمراجعة بيانات المنتج مرة أخرى", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Items_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Items.Rows.Count > 1)
            {
                ProductCodeBox.Text = Items.CurrentRow.Cells[0].Value.ToString();
                ProductnameBox.Text = Items.CurrentRow.Cells[1].Value.ToString();
                ClassificationBox.Text = Items.CurrentRow.Cells[2].Value.ToString();
                QuantityBox.Text = Items.CurrentRow.Cells[3].Value.ToString();
                ColorBox.Text = Items.CurrentRow.Cells[4].Value.ToString();
                SizeBox.Text = Items.CurrentRow.Cells[5].Value.ToString();
                PriceBox.Text = Items.CurrentRow.Cells[6].Value.ToString();
                DiscountBox.Text = Items.CurrentRow.Cells[7].Value.ToString();
                NotesBox.Text = Items.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("الفاتورة فارغة لا تحتوى على منتجات مضافة  حتى الان", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private async void Clear()
        {
            ProductCodeBox.Clear();
            ProductnameBox.Clear();
            ClassificationBox.Text = "";
            QuantityBox.Clear();
            ColorBox.SelectedIndex = -1;
            SizeBox.Text = "";
            DiscountBox.Clear();
            PriceBox.Clear();
            NotesBox.Clear();
            TotalPriceBox.Text = "0";
            PaidUp.Clear();
            FaturaDiscountBox.Text = "0";
            AfterDiscount.Clear();
            order = await buyBillService.GetLastOrderID();
            BillCodeBox.Text = (order.ID + 1).ToString();

        }

        private void FaturaDiscountBox_TextChanged(object sender, EventArgs e)
        {

            if (FaturaDiscountBox.Text == "")
            {
                FaturaDiscountBox.Text = 0.ToString();
            }
            double totalPrice = double.Parse(TotalPriceBox.Text);
            double Discount = double.Parse(FaturaDiscountBox.Text);
            double FinalPrice = totalPrice - (totalPrice * ((Discount / 100)));
            AfterDiscount.Text = FinalPrice.ToString("F3");
            PaidUp.Text = FinalPrice.ToString("F3");
        }


        private void TotalPriceBox_TextChanged(object sender, EventArgs e)
        {
            AfterDiscount.Text = TotalPriceBox.Text;
            PaidUp.Text = TotalPriceBox.Text;
        }


        private async void Savebtn_ClickAsync(object sender, EventArgs e)
        {
            if (Items.Rows.Count <= 1)
            {
                MessageBox.Show("يرجى إضافة منتجات للفاتورة اولا لكى تتم عملية الحفظ بنجاح ", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Order order = new Order();
                order.IsSale = true;
                order.OrderDate = DateTime.ParseExact(Date.Text, "yyyy/dd/MM", CultureInfo.InvariantCulture);
                order.user_id = int.Parse(UserIDBox.Text);
                await buyBillService.AddOrder(order);
                int orderId = order.ID;
                OrderItems orderItems = new OrderItems();
                Product product = new Product();
                for (int i = 0; i < Items.Rows.Count - 1; i++)
                {

                    if (int.Parse(Items.Rows[i].Cells[10].Value.ToString()) != null && double.Parse(Items.Rows[i].Cells[8].Value.ToString()) != null && double.Parse(Items.Rows[i].Cells[7].Value.ToString()) != null
                        && int.Parse(Items.Rows[i].Cells[3].Value.ToString()) != null)
                    {
                        orderItems.Order_Id = int.Parse(Items.Rows[i].Cells[11].Value.ToString());
                        orderItems.product_Id = int.Parse(Items.Rows[i].Cells[10].Value.ToString());
                        orderItems.TotalPrice = double.Parse(Items.Rows[i].Cells[8].Value.ToString());
                        orderItems.Discount = double.Parse(Items.Rows[i].Cells[7].Value.ToString());
                        orderItems.Quantity = int.Parse(Items.Rows[i].Cells[3].Value.ToString());
                        product = await productService.GetProductByID(int.Parse(ProductIDBox.Text));
                        product.StockAmount += int.Parse(Items.Rows[i].Cells[3].Value.ToString());
                        await productService.UpdateProduct(product);
                        buyBillService.AddOrderItem(orderItems);
                        buyBillService.UpdateMoneyStock(int.Parse(branchIdBox.Text), double.Parse(PaidUp.Text));
                        if (SupplierBox.SelectedIndex != -1)
                        {
                            _productsSuppliers.Supplier_Id = (int)SupplierBox.SelectedValue;
                            _productsSuppliers.product_Id = int.Parse(ProductIDBox.Text);
                            await _suppliersProductsService.addSuppliersforProducts(_productsSuppliers);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"الفاتورة تحتوى على بيانات ناقصة يرجى ملئ جميع البيانات ومن ثم حفظها", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    }
                }

                MessageBox.Show($"{orderId} : تم حفظ الفاتورة بنجاح رقم الفاتورة هو", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Items.Rows.Clear();
                Clear();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (Items.SelectedCells.Count > 1)
            {
                int RowIndex = Items.SelectedCells[0].RowIndex;
                if (MessageBox.Show("هل انت متأكد من حذف هذا المنتج من هذه الفاتورة؟ ", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (RowIndex != null)
                        {
                            double SelectedCellPrice = double.Parse(Items.CurrentRow.Cells[8].Value.ToString());
                            double CurrentTotalPrice = double.Parse(TotalPriceBox.Text);
                            CurrentTotalPrice -= SelectedCellPrice;
                            Items.Rows.RemoveAt(RowIndex);
                            TotalPriceBox.Text = CurrentTotalPrice.ToString();

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("لا يوجد منتجات فى الفاتورة حتى الان لكى يتم حذفها ", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد منتج من الفاتورة لكى يتم حذفه", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (DiscountBox.Text == "")
                {
                    DiscountBox.Text = 0.ToString();
                }
                double Quantity = int.Parse(QuantityBox.Text);
                double Price = double.Parse(PriceBox.Text);
                double Discount = double.Parse(DiscountBox.Text);
                double TotalPrice = Quantity * Price;
                double afterDiscount = TotalPrice - (TotalPrice * (Discount / 100));
                string formattedResult = afterDiscount.ToString("F3");


                Items.CurrentRow.Cells[0].Value = ProductCodeBox.Text;
                Items.CurrentRow.Cells[1].Value = ProductnameBox.Text;
                Items.CurrentRow.Cells[2].Value = ClassificationBox.Text;
                Items.CurrentRow.Cells[3].Value = QuantityBox.Text;
                Items.CurrentRow.Cells[4].Value = ColorBox.Text;
                Items.CurrentRow.Cells[5].Value = SizeBox.Text;
                Items.CurrentRow.Cells[6].Value = PriceBox.Text;
                Items.CurrentRow.Cells[7].Value = DiscountBox.Text;
                Items.CurrentRow.Cells[8].Value = formattedResult;
                Items.CurrentRow.Cells[9].Value = NotesBox.Text;
                double sum = 0;
                for (int i = 0; i < Items.Rows.Count - 1; ++i)
                {
                    sum += double.Parse(Items.Rows[i].Cells[8].Value.ToString());
                }
                TotalPriceBox.Text = sum.ToString("F3");
                AfterDiscount.Text = sum.ToString("F3");
                PaidUp.Text = sum.ToString("F3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("قم بتحديد المنتج المراد تعديله اولا", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                ProductCodeBox.Text = SearchBox.Text;
            }
        }
    }
}
