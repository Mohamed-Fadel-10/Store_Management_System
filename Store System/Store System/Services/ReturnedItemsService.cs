using Microsoft.EntityFrameworkCore;
using Store_System.Data;
using Store_System.Models;
using Store_System.UI.ControlPanelUi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReturnedItems = Store_System.Models.ReturnedItems;

namespace Store_System.Services
{
    internal class ReturnedItemsService
    {
        StoreContext _context;
        public ReturnedItemsService()
        {
            _context = new StoreContext();
        }

        

         
        //public List<(string Name, string Barcode, string Size, string Color, int Quantity, string CategoryName)> GetAllOrders(int id)
        //{
        //    var query = _context.Product
        //        .Join(_context.OrderItems,
        //              p => p.ID,
        //              o => o.product_Id,
        //              (p, o) => new { Product = p, OrderItem = o })
        //        .Join(_context.Order,
        //              po => po.OrderItem.Order_Id,
        //              order => order.ID,
        //              (po, order) => new { ProductOrder = po, Order = order })
        //        .Where(po => po.Order.ID == 62)
        //        .Select(po => new
        //        {
        //            Name = po.ProductOrder.Product.Name,
        //            Barcode = po.ProductOrder.Product.Barcode,
        //            Size = po.ProductOrder.Product.Size,
        //            Color = po.ProductOrder.Product.Color,
        //            Quantity = po.ProductOrder.OrderItem.Quantity,
        //            CategoryName = po.ProductOrder.Product.CategoryName
        //        });

        //    var result = query.ToList().Select(x => (
        //        x.Name,
        //        x.Barcode,
        //        x.Size,
        //        x.Color,
        //        x.Quantity,
        //        x.CategoryName
        //    )).ToList();

        //  //  return result.ToList();
        //}

        public Returned AddReturned(Returned returned)
        {
            if(returned != null) {
                _context.Returned.Add(returned);
                _context.SaveChanges();
                return returned;
            }
            else
            {
                return new Returned();
            }

        }
        public ReturnedItems AddReturnedItems(ReturnedItems returnedItems)
        {
            if (returnedItems != null)
            {
                 _context.ReturnedItems.Add(returnedItems);
                 _context.SaveChanges();
                return returnedItems;
            }
            else
            {
                return new ReturnedItems();
            }
        }
        public async Task<OrderItems> GetOrderItems(int ProductID,int OrderID)
        {
         OrderItems order=  await _context.OrderItems.FirstOrDefaultAsync(o=>o.product_Id==ProductID&&o.Order_Id==OrderID);
            if(order != null)
            {
                return order;
            }
            else { return new OrderItems(); }
        }
        public Product GetProduct(int ProductID)
        {
            Product product =  _context.Product.FirstOrDefault(o => o.ID == ProductID);
            if (product != null)
            {
                return product;
            }
            else { return new Product(); }
        }
        public int UpdateProduct(Product product)
        {
            if (product != null)
            {
              return _context.SaveChanges();
            }
            else
            {
                return 0;
            }
            
        }
        public int DeleteOrderItem(int productID,int orderID)
        {
            if (productID != null&&orderID!=null) {
                 var orderitem=  _context.OrderItems.Where(o=>o.Order_Id==orderID&&o.product_Id==productID).FirstOrDefault();
               _context.OrderItems.Remove(orderitem);
                _context.SaveChanges();
                return 1;
                 }
            else
            return 0;
        }
        public async Task<Returned> GetLastReturnedID()
        {
            Returned id = await _context.Returned.OrderByDescending(o => o.id).FirstOrDefaultAsync();
            return id;
        }


    }
}
