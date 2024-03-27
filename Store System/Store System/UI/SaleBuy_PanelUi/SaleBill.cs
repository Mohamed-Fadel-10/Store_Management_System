using Store_System.Data;
using Microsoft.VisualBasic;
using Store_System.Data;
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

namespace Store_System.UI.ControlPanelUi
{
    public partial class SaleBill : UserControl
    {
        CategoryService _categoryService;
        SaleBillService _saleBillService;
        ProductService _productService;
        Order _order;
        ShiftLock _shiftLock;
        Product _product;
        User _user;
        UserServices _userService;

        public string CustomerName { get; set; }
        public string Username { get; set; }


        public SaleBill()
        {
            InitializeComponent();
            _saleBillService = new SaleBillService();
            _categoryService = new CategoryService();
            _productService = new ProductService();
            _order = new Order();
            _product = new Product();
            _user = new User();
            _userService = new UserServices();
        }


        private async void ProductCodeBox_TextChanged(object sender, EventArgs e)
        {
            string barcode = ProductCodeBox.Text;
            if (barcode != "")
            {

                Product Product = await _saleBillService.GetProductCode(barcode);

                if (Product != null)
                {
                    try
                    {
                        productID.Text = Product.ID.ToString();
                        ProductCodeBox.Text = Product.Barcode;
                        ProductnameBox.Text = Product.Name;
                        ClassificationBox.Text = Product.Category.Name;
                        ColorBox.Text = Product.Color;
                        SizeBox.Text = Product.Size.ToString();
                        SellingPrice.Text = Product.SellingPrice.ToString();
                        QuantityBox.Text = 1.ToString();
                        QuantityBox.Focus();
                        _discountBox.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("يرجى إدخال باركود المنتج", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ProductnameBox.Clear();
                    ClassificationBox.Text = "";
                    QuantityBox.Clear();
                    ColorBox.Text = "";
                    SizeBox.Text = "";
                    SellingPrice.Clear();
                }
            }
        }

        private async void SaleBill_Load(object sender, EventArgs e)
        {

            _order = await _saleBillService.GetLastOrderID();

            //BillCodeBox.Text = (_order.ID + 1).ToString(); // add one to last id to insert it ( 0 ==> 0 + 1 = 1 ) ههههه
            var Categories = await _categoryService.GetALlCategories();
            ClassificationBox.DataSource = Categories;
            ClassificationBox.DisplayMember = "Name";
            ClassificationBox.ValueMember = "ID";
            ClassificationBox.SelectedIndex = -1;
            ProductCodeBox.Focus();
            Date.Text = DateTime.Now.ToString();

        }
        private AddCustomer addCustomer;

        private void button1_Click(object sender, EventArgs e)
        {
            addCustomer = new AddCustomer();
            addCustomer.FormClosed += AddCustomer_FormClosed;
            addCustomer.ShowDialog();

            customerIDBox.Text = addCustomer.CustomerID.ToString();

        }

        private void AddCustomer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (addCustomer != null && !string.IsNullOrEmpty(addCustomer.CustomerName))
            {
                _CustomerNameBox.Text = addCustomer.CustomerName;
            }
        }

        private async void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                for (int i = 0; i < Items.Rows.Count - 1; ++i)
                {
                    if (ProductCodeBox.Text == Items.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("هذا المنتج موجود بالفعل" +
                                        " يمكنك التعديل عليه بدلا من اضافته مجددا", "انتبه!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = true;
                    }
                }
                if (!flag)
                {
                    _product = await _productService.GetProductByID(int.Parse(productID.Text));

                    if (_discountBox.Text == "")
                    {
                        _discountBox.Text = 0.ToString();
                    }
                    if (_product.StockAmount <= 0 || _product.StockAmount < int.Parse(QuantityBox.Text))
                    {
                        MessageBox.Show($"{_product.StockAmount} : هذا المنتج لا يحتوى على كميات متاحة فى المخزن، المتاح حاليا ", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        double Quantity = int.Parse(QuantityBox.Text);
                        double Price = double.Parse(SellingPrice.Text);
                        double Discount = double.Parse(_discountBox.Text);
                        double TotalPrice = Quantity * Price;
                        double afterDiscount = TotalPrice - (TotalPrice * ((Discount / 100)));
                        string formattedResult = afterDiscount.ToString("F3");
                        //=================================================
                        Order lastOrderID = await _saleBillService.GetLastOrderID();
                        Items.Rows.Add(ProductCodeBox.Text, ProductnameBox.Text, ClassificationBox.Text, QuantityBox.Text, ColorBox.Text, SizeBox.Text, SellingPrice.Text, _discountBox.Text, formattedResult, NotesBox.Text, productID.Text, ((lastOrderID.ID) + 1));

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
                }
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
                SellingPrice.Text = Items.CurrentRow.Cells[6].Value.ToString();
                _discountBox.Text = Items.CurrentRow.Cells[7].Value.ToString();
                NotesBox.Text = Items.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("الفاتورة فارغة لا تحنوى على منتجات مضافة  حتى الان", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_discountBox.Text == "")
                {
                    _discountBox.Text = 0.ToString();
                }
                double Quantity = int.Parse(QuantityBox.Text);
                double Price = double.Parse(SellingPrice.Text);
                double Discount = double.Parse(_discountBox.Text);
                double TotalPrice = Quantity * Price;
                double afterDiscount = TotalPrice - (TotalPrice * (Discount / 100));
                string formattedResult = afterDiscount.ToString("F3");


                Items.CurrentRow.Cells[0].Value = ProductCodeBox.Text;
                Items.CurrentRow.Cells[1].Value = ProductnameBox.Text;
                Items.CurrentRow.Cells[2].Value = ClassificationBox.Text;
                Items.CurrentRow.Cells[3].Value = QuantityBox.Text;
                Items.CurrentRow.Cells[4].Value = ColorBox.Text;
                Items.CurrentRow.Cells[5].Value = SizeBox.Text;
                Items.CurrentRow.Cells[6].Value = SellingPrice.Text;
                Items.CurrentRow.Cells[7].Value = _discountBox.Text;
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
        private async void Clear()
        {
            ProductCodeBox.Clear();
            ProductnameBox.Clear();
            ClassificationBox.Text = "";
            QuantityBox.Clear();
            ColorBox.Clear();
            SizeBox.Text = "";
            _discountBox.Clear();
            SellingPrice.Clear();
            NotesBox.Clear();
            TotalPriceBox.Text = "0";
            PaidUp.Clear();
            FaturaDiscountBox.Text = 0.ToString();
            AfterDiscount.Clear();
            _order = await _saleBillService.GetLastOrderID();
            BillCodeBox.Text = (_order.ID + 1).ToString();

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

        private void TotalPriceBox_TextChanged(object sender, EventArgs e)
        {
            AfterDiscount.Text = TotalPriceBox.Text;
            PaidUp.Text = TotalPriceBox.Text;
        }

        private async void Savebtn_Click(object sender, EventArgs e)
        {
            if (Items.Rows.Count <= 1)
            {
                MessageBox.Show("يرجى إضافة منتجات للفاتورة اولا لكى تتم عملية الحفظ بنجاح ", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _order = new Order();
                if (customerIDBox.Text == "")
                {
                    _order.Customer_Id = null;
                }
                else
                {
                    _order.Customer_Id = int.Parse(customerIDBox.Text);
                }
                _order.user_id = int.Parse(UserIDBox.Text);
                _order.IsSale = false;
                _order.OrderDate = DateTime.Parse(Date.Text);

                await _saleBillService.AddOrder(_order);
                int orderId = _order.ID;
                OrderItems orderItems = new OrderItems();
                Product product = new Product();

                ShiftLockService.GetShiftMoneyChanged(double.Parse(PaidUp.Text));


                for (int i = 0; i < Items.Rows.Count - 1; i++)
                {

                    if (int.Parse(Items.Rows[i].Cells[10].Value.ToString()) != null && double.Parse(Items.Rows[i].Cells[8].Value.ToString()) != null && double.Parse(Items.Rows[i].Cells[7].Value.ToString()) != null
                        && int.Parse(Items.Rows[i].Cells[3].Value.ToString()) != null)
                    {
                        orderItems.Size = Items.Rows[i].Cells[5].Value.ToString();
                        orderItems.Color = Items.Rows[i].Cells[4].Value.ToString();
                        orderItems.Description = Items.Rows[i].Cells[9].Value.ToString();
                        orderItems.Order_Id = int.Parse(Items.Rows[i].Cells[11].Value.ToString());
                        orderItems.product_Id = int.Parse(Items.Rows[i].Cells[10].Value.ToString());
                        orderItems.TotalPrice = double.Parse(Items.Rows[i].Cells[8].Value.ToString());
                        orderItems.Discount = double.Parse(Items.Rows[i].Cells[7].Value.ToString());
                        orderItems.Quantity = int.Parse(Items.Rows[i].Cells[3].Value.ToString());
                        _product = await _productService.GetProductByBarcode(Items.Rows[i].Cells[0].Value.ToString());
                        _product.StockAmount -= int.Parse(Items.Rows[i].Cells[3].Value.ToString());
                        await _productService.UpdateProduct(_product);
                        _saleBillService.AddOrderItem(orderItems);
                    }
                    else
                    {
                        MessageBox.Show($"الفاتورة تحتوى على بيانات ناقصة يرجى ملئ جميع البيانات ومن ثم حفظها", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    }
                }

                MessageBox.Show($"{orderId} : تم حفظ الفاتورة بنجاح رقم الفاتورة هو", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _user = await _userService.GetUserByID(int.Parse(UserIDBox.Text));
                _user.MoneyStockAmount += double.Parse(PaidUp.Text);
                await _userService.UpdateUser(_user);
                Items.Rows.Clear();
                Clear();
            }
        }

        private void PaidUp_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
