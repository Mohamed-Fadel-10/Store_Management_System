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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace Store_System.UI.ControlPanelUi
{
    public partial class ReturnedItems : UserControl
    {
        ReturnedItemsService _returnedItemsService;
        CategoryService _categoryService;
        StoreContext _context;


        public ReturnedItems()
        {
            InitializeComponent();
            _returnedItemsService = new ReturnedItemsService();
            _categoryService = new CategoryService();
            _context = new StoreContext();
        }
        private async void ReturnedItems_Load(object sender, EventArgs e)
        {

            SizeBox.SelectedIndex = -1;
            Returned returned = await _returnedItemsService.GetLastReturnedID();
            if (returned == null)
            {
                ReturnedID.Text = "1";
            }
            else { ReturnedID.Text = (returned.id + 1).ToString(); }
        }
        private void ok_Click(object sender, EventArgs e)
        {
            var Products = _context.Product
                  .Join(_context.OrderItems,
                        p => p.ID,
              o => o.product_Id,
                        (p, o) => new { Product = p, OrderItem = o })
                  .Join(_context.Order,
                        po => po.OrderItem.Order_Id,
                        order => order.ID,
                        (po, order) => new { ProductOrder = po, Order = order })
                  .Where(po => po.Order.ID == int.Parse(BillCodeBox.Text))
                  .Select(po => new
                  {
                      ID = po.ProductOrder.Product.ID,
                      Name = po.ProductOrder.Product.Name,
                      Barcode = po.ProductOrder.Product.Barcode,
                      Size = po.ProductOrder.OrderItem.Size,
                      Color = po.ProductOrder.OrderItem.Color,
                      Quantity = po.ProductOrder.OrderItem.Quantity,
                      CategoryName = po.ProductOrder.Product.Category.Name,
                      Price = po.ProductOrder.OrderItem.TotalPrice,
                      Discount = po.ProductOrder.OrderItem.Discount,

                  });

            var result = Products.ToList().Select(x => (
                x.ID,
                x.Name,
                x.Barcode,
                x.Size,
                x.Color,
                x.Quantity,
                x.CategoryName,
                x.Price,
                x.Discount
            )).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("إسم المنتج", typeof(string));
            dt.Columns.Add("باركود المنتج", typeof(string));
            dt.Columns.Add("المقاس", typeof(string));
            dt.Columns.Add("اللون", typeof(string));
            dt.Columns.Add("الكمية", typeof(int));
            dt.Columns.Add("نوع الصنف", typeof(string));
            dt.Columns.Add("سعر البيع", typeof(double));
            dt.Columns.Add("الخصم", typeof(double));

            foreach (var item in result)
            {
                dt.Rows.Add(item.ID, item.Name, item.Barcode, item.Size, item.Color, item.Quantity, item.CategoryName, item.Price, item.Discount);
            }

            Items.DataSource = dt;
        }

        private void Items_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productID.Text = Items.CurrentRow.Cells[0].Value.ToString();
            ProductCodeBox.Text = Items.CurrentRow.Cells[2].Value.ToString();
            ProductnameBox.Text = Items.CurrentRow.Cells[1].Value.ToString();
            CatComboBox.Text = Items.CurrentRow.Cells[6].Value.ToString();
            QuantityBox.Text = Items.CurrentRow.Cells[5].Value.ToString();
            _discountBox.Text = Items.CurrentRow.Cells[8].Value.ToString();
            ColorBox.Text = Items.CurrentRow.Cells[4].Value.ToString();
            SizeBox.Text = Items.CurrentRow.Cells[3].Value.ToString();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Returned returned = new Returned();
            returned.Date = DateTime.Now.Date;
            _returnedItemsService.AddReturned(returned);
            ReturnedItemsGridview.Rows.Add(ProductnameBox.Text, ProductCodeBox.Text, SizeBox.Text
                , ColorBox.Text, QuantityBox.Text, CatComboBox.Text, _discountBox.Text, returned.id, productID.Text);

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Models.ReturnedItems returnedItems = new Models.ReturnedItems();
            Returned returned = new Returned();
            returned.Date = DateTime.Now;
            _returnedItemsService.AddReturned(returned);

            for (int i = 0; i < ReturnedItemsGridview.Rows.Count - 1; i++)
            {
                returnedItems.OrderID = int.Parse(BillCodeBox.Text);
                returnedItems.Returned_Id = int.Parse(ReturnedItemsGridview.Rows[i].Cells[7].Value.ToString());
                returnedItems.ReturnedQuantity = int.Parse(ReturnedItemsGridview.Rows[i].Cells[4].Value.ToString());
                returnedItems.Product_Id = int.Parse(ReturnedItemsGridview.Rows[i].Cells[8].Value.ToString());
                _returnedItemsService.AddReturnedItems(returnedItems);
                _returnedItemsService.DeleteOrderItem(int.Parse(productID.Text), int.Parse(BillCodeBox.Text));
                Product product = _returnedItemsService.GetProduct(int.Parse(productID.Text));
                product.StockAmount += int.Parse(ReturnedItemsGridview.Rows[i].Cells[4].Value.ToString());
                _returnedItemsService.UpdateProduct(product);

                MessageBox.Show("تمت إضافة الفاتورة بنجاح ال المرتجعات", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

            }
        }

        private void DeleteitemBtn_Click(object sender, EventArgs e)
        {
            if (ReturnedItemsGridview.SelectedCells.Count > 1)
            {
                int RowIndex = ReturnedItemsGridview.SelectedCells[0].RowIndex;
                if (MessageBox.Show("هل انت متأكد من حذف هذا المنتج من هذه الفاتورة؟ ", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (RowIndex != null)
                        {
                            ReturnedItemsGridview.Rows.RemoveAt(RowIndex);
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
        private void Clear()
        {
            ReturnedItemsGridview.Rows.Clear();
            BillCodeBox.Text = "";
            ProductCodeBox.Text = "";
            ProductnameBox.Text = ""; 
            CatComboBox.Text = "";
            QuantityBox.Text = ""; 
            _discountBox.Text = "";
            ColorBox.Text = "";
            SizeBox.Text = ""; 
            NotesBox.Text = "";
        }
    }
}
