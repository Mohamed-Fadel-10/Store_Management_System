using Microsoft.EntityFrameworkCore;
using Store_System.Data;
using Store_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<Returned> AddReturned(Returned returned)
        {
            if(returned != null) {
               await _context.Returned.AddAsync(returned);
               await _context.SaveChangesAsync();
                return returned;
            }
            else
            {
                return new Returned();
            }

        }
        public async Task<ReturnedItems> AddReturnedItems(ReturnedItems returnedItems)
        {
            if (returnedItems != null)
            {
                await _context.ReturnedItems.AddAsync(returnedItems);
                await _context.SaveChangesAsync();
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
        public async Task<Product> GetProduct(int ProductID)
        {
            Product product = await _context.Product.FirstOrDefaultAsync(o => o.ID == ProductID);
            if (product != null)
            {
                return product;
            }
            else { return new Product(); }
        }
        public async Task<int> UpdateProduct(Product product)
        {
            if (product != null)
            {
              return   await _context.SaveChangesAsync();
            }
            else
            {
                return 0;
            }
            
        }
        public async Task<int> DeleteOrderItem(OrderItems orderItems)
        {
            if (orderItems != null) {
                _context.OrderItems.Remove(orderItems);
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
