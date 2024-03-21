using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Store_System.Data;
using Store_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Services
{
    internal class BuyBillService
    {
        StoreContext _context;

        public BuyBillService()
        {
            _context = new StoreContext();
        }


        public async Task<int> AddOrder(Order order)
        {
            if (order != null)
            {
                await _context.Order.AddAsync(order);
                int row = await _context.SaveChangesAsync();
                return row;
            }
            else
                return 0;
        }


        public int AddOrderItem(OrderItems orderItems)
        {
            if (orderItems != null)
            {
                _context.OrderItems.Add(orderItems);
                int row = _context.SaveChanges();
                return row;
            }
            else
                return 0;
        }


        public async Task<Order> GetLastOrderID()
        {
            Order id = await _context.Order.OrderByDescending(o => o.ID).FirstOrDefaultAsync();
            return id;
        }

        public async Task<Product> GetProductCode(string barcode)
        {
            var Product = await _context.Product.Include(c => c.Category).FirstOrDefaultAsync(p => p.Barcode == barcode);
            if (Product != null)
            {
                return Product;
            }
            else
            {
                return new Product();
            }
        }

        public async Task<int> UpdateMoneyStock(int branch_id,double money)
        {
            Branch branch = await _context.Branch.FirstOrDefaultAsync(b => b.ID == branch_id);

            if (branch != null)
            {
                branch.MainMoneyStock -= money;
                return await _context.SaveChangesAsync();
            }

            return 0;
        }
    }
}
