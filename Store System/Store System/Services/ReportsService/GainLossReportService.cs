using Store_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Services.ReportsService
{
    public class GainLossReportService
    {
        StoreContext _context;
        DateTime CurrentDate;
        DateTime PreviousMonth;
        DateTime PreviousYear;
        public GainLossReportService()
        {
            _context = new StoreContext();
            CurrentDate = DateTime.Now;
            PreviousMonth = CurrentDate.AddMonths(-1);
            PreviousYear = CurrentDate.AddYears(-1);
        }
        public double TotalPriceSale(DateTime FromDate, DateTime ToDate)
        {
            double query = _context.OrderItems
        .Join(_context.Order,
              o => o.Order_Id,
              op => op.ID,
              (o, op) => new { OrderItem = o, Order = op })
        .Where(x => x.Order.OrderDate >= FromDate && x.Order.OrderDate <= ToDate && x.Order.IsSale == false)
        .Sum(x => x.OrderItem.TotalPrice);
            return query;

        }

        public double TotalPriceBuy(DateTime FromDate, DateTime ToDate)
        {
            double query = _context.OrderItems
                  .Join(_context.Product, op => op.product_Id, p => p.ID, (op, p) => new { orderItem = op, product = p })
                  .Join(_context.Order,
                  o => o.orderItem.Order_Id,
                  op => op.ID,
                  (o, op) => new { OrderItem = o, Order = op })
                 .Where(x => x.Order.OrderDate >= FromDate && x.Order.OrderDate <= ToDate && x.Order.IsSale == true)
                  .Sum(x => x.OrderItem.orderItem.TotalPrice);
            return query;
        }

        /// ===================================================================================================
        public double TotalPriceBuyDay()
        {
            double query = _context.OrderItems
                  .Join(_context.Product, op => op.product_Id, p => p.ID, (op, p) => new { orderItem = op, product = p })
                  .Join(_context.Order,
                  o => o.orderItem.Order_Id,
                  op => op.ID,
                  (o, op) => new { OrderItem = o, Order = op })
                 .Where(x => x.Order.OrderDate == CurrentDate && x.Order.IsSale == true)
                  .Sum(x => x.OrderItem.orderItem.TotalPrice);
            return query;
        }
        public double TotalPriceBuyMonth()
        {
            double query = _context.OrderItems
                  .Join(_context.Product, op => op.product_Id, p => p.ID, (op, p) => new { orderItem = op, product = p })
                  .Join(_context.Order,
                  o => o.orderItem.Order_Id,
                  op => op.ID,
                  (o, op) => new { OrderItem = o, Order = op })
                 .Where(x => x.Order.OrderDate >=PreviousMonth && x.Order.OrderDate< CurrentDate && x.Order.IsSale == true)
                  .Sum(x => x.OrderItem.orderItem.TotalPrice);
            return query;
        }
        public double TotalPriceBuyYear()
        {
            double query = _context.OrderItems
                  .Join(_context.Product, op => op.product_Id, p => p.ID, (op, p) => new { orderItem = op, product = p })
                  .Join(_context.Order,
                  o => o.orderItem.Order_Id,
                  op => op.ID,
                  (o, op) => new { OrderItem = o, Order = op })
                 .Where(x => x.Order.OrderDate >= PreviousYear &&
                            x.Order.OrderDate < CurrentDate && x.Order.IsSale == true)
                  .Sum(x => x.OrderItem.orderItem.TotalPrice);
            return query;
        }
        ///========================================================================
        public double TotalPriceSaleDay()
        {
            double query = _context.OrderItems 
                  .Join(_context.Product, op => op.product_Id, p => p.ID, (op, p) => new { orderItem = op, product = p })
                  .Join(_context.Order,
                  o => o.orderItem.Order_Id,
                  op => op.ID,
                  (o, op) => new { OrderItem = o, Order = op })
                 .Where(x => x.Order.OrderDate == CurrentDate && x.Order.IsSale == false)
                  .Sum(x => x.OrderItem.orderItem.TotalPrice);
            return query;
        }
        public double TotalPriceSaleMonth()
        {
            double query = _context.OrderItems
                  .Join(_context.Product, op => op.product_Id, p => p.ID, (op, p) => new { orderItem = op, product = p })
                  .Join(_context.Order,
                  o => o.orderItem.Order_Id,
                  op => op.ID,
                  (o, op) => new { OrderItem = o, Order = op })
                 .Where(x => x.Order.OrderDate >= PreviousMonth && x.Order.OrderDate < CurrentDate && x.Order.IsSale == false)
                  .Sum(x => x.OrderItem.orderItem.TotalPrice);
            return query;
        }
        public double TotalPriceSaleYear()
        {
            double query = _context.OrderItems
                  .Join(_context.Product, op => op.product_Id, p => p.ID, (op, p) => new { orderItem = op, product = p })
                  .Join(_context.Order,
                  o => o.orderItem.Order_Id,
                  op => op.ID,
                  (o, op) => new { OrderItem = o, Order = op })
                 .Where(x => x.Order.OrderDate >= PreviousYear &&
                            x.Order.OrderDate < CurrentDate && x.Order.IsSale == false)
                  .Sum(x => x.OrderItem.orderItem.TotalPrice);
            return query;
        }


    }
}
