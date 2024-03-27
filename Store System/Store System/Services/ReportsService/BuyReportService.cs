using Store_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Services.ReportsService
{
    internal class BuyReportService
    {
        StoreContext _context;
        DateTime CurrentDate;
        DateTime PreviousMonth;
        DateTime PreviousYear;
        public BuyReportService()
        {
            _context = new StoreContext();
            CurrentDate = DateTime.Now;
            PreviousMonth = CurrentDate.AddMonths(-1);
            PreviousYear = CurrentDate.AddYears(-1);
        }

        public List<BindingOrdersAndItems> CustomBill(int id)
        {
            var query = _context.OrderItems
                .Join(_context.Product,
            i => i.product_Id,
            p => p.ID,
            (i, p) => new { OrderItem = i, Product = p })
            .Join(_context.Order,
                  i => i.OrderItem.Order_Id,
                  o => o.ID,
                  (i, o) => new { OrderItem = i, Order = o })
            .Where(x => x.Order.ID == id && x.Order.IsSale == true)
              .Select(x => new BindingOrdersAndItems
              {
                  Order_ID = x.OrderItem.OrderItem.Order_Id,
                  Date = x.Order.OrderDate.Value,
                  Quantity = x.OrderItem.OrderItem.Quantity,
                  Discount = x.OrderItem.OrderItem.Discount,
                  TotalPrice = x.OrderItem.OrderItem.TotalPrice,
                  Barcode = x.OrderItem.Product.Barcode.ToString()
              })
                .ToList();

            if (query != null)
            {
                return query;
            }
            else return new List<BindingOrdersAndItems>();

        }
        public List<BindingOrdersAndItems> OneDayOrders()
        {
            var query = _context.OrderItems
                .Join(_context.Product,
            i => i.product_Id,
            p => p.ID,
            (i, p) => new { OrderItem = i, Product = p })
            .Join(_context.Order,
                  i => i.OrderItem.Order_Id,
                  o => o.ID,
                  (i, o) => new { OrderItem = i, Order = o })
            .Where(x => x.Order.OrderDate == DateTime.Today && x.Order.IsSale == true)
              .Select(x => new BindingOrdersAndItems
              {
                  Order_ID = x.OrderItem.OrderItem.Order_Id,
                  Date = x.Order.OrderDate.Value,
                  Quantity = x.OrderItem.OrderItem.Quantity,
                  Discount = x.OrderItem.OrderItem.Discount,
                  TotalPrice = x.OrderItem.OrderItem.TotalPrice,
                  Barcode = x.OrderItem.Product.Barcode.ToString()
              })
                .ToList();

            if (query != null)
            {
                return query;
            }
            else return new List<BindingOrdersAndItems>();

        }
        public List<BindingOrdersAndItems> MonthOrders()
        {

            var query = _context.OrderItems
                .Join(_context.Order,
                      o => o.Order_Id,
                      op => op.ID,
                      (o, op) => new { OrderItem = o, Order = op })
                .Where(x => x.Order.OrderDate >= PreviousMonth &&
                            x.Order.OrderDate < CurrentDate &&
                            x.Order.IsSale == true)
                .Select(x => new BindingOrdersAndItems
                {
                    Order_ID = x.OrderItem.Order_Id,
                    Date = x.Order.OrderDate.Value,
                    Quantity = x.OrderItem.Quantity,
                    Discount = x.OrderItem.Discount,
                    TotalPrice = x.OrderItem.TotalPrice,
                    Barcode = x.OrderItem.Product.Barcode.ToString()
                })
                .ToList();

            return query;
        }

        public List<BindingOrdersAndItems> YearOrders()
        {

            var query = _context.OrderItems
                .Join(_context.Order,
                      o => o.Order_Id,
                      op => op.ID,
                      (o, op) => new { OrderItem = o, Order = op })
                .Where(x => x.Order.OrderDate >= PreviousYear &&
                            x.Order.OrderDate < CurrentDate &&
                            x.Order.IsSale == true)
                .Select(x => new BindingOrdersAndItems
                {
                    Order_ID = x.OrderItem.Order_Id,
                    Date = x.Order.OrderDate.Value,
                    Quantity = x.OrderItem.Quantity,
                    Discount = x.OrderItem.Discount,
                    TotalPrice = x.OrderItem.TotalPrice,
                    Barcode = x.OrderItem.Product.Barcode.ToString()
                })
                .ToList();

            return query;
        }

        public double TotalPriceDay()
        {
            double query = _context.OrderItems
        .Join(_context.Order,
              o => o.Order_Id,
              op => op.ID,
              (o, op) => new { OrderItem = o, Order = op })
        .Where(x => x.Order.OrderDate == DateTime.Today && x.Order.IsSale == true)
        .Sum(x => x.OrderItem.TotalPrice);
            return query;

        }
        public double TotalPriceMonthe()
        {
            double query = _context.OrderItems
        .Join(_context.Order,
              o => o.Order_Id,
              op => op.ID,
              (o, op) => new { OrderItem = o, Order = op })
        .Where(x => x.Order.OrderDate >= PreviousMonth && x.Order.OrderDate <= CurrentDate && x.Order.IsSale == true)
        .Sum(x => x.OrderItem.TotalPrice);
            return query;

        }
        public double TotalPriceYear()
        {
            double query = _context.OrderItems
        .Join(_context.Order,
              o => o.Order_Id,
              op => op.ID,
              (o, op) => new { OrderItem = o, Order = op })
        .Where(x => x.Order.OrderDate >= PreviousYear && x.Order.OrderDate <= CurrentDate && x.Order.IsSale == true)
        .Sum(x => x.OrderItem.TotalPrice);
            return query;

        }
        public double TotalPriceCustom(int id)
        {
            double query = _context.OrderItems
        .Join(_context.Order,
              o => o.Order_Id,
              op => op.ID,
              (o, op) => new { OrderItem = o, Order = op })
        .Where(x => x.Order.ID == id && x.Order.IsSale == true)
        .Sum(x => x.OrderItem.TotalPrice);
            return query;

        }
        public int CountOrdersDay()
        {
            int query = _context.OrderItems
     .Join(_context.Order,
           o => o.Order_Id,
           op => op.ID,
           (o, op) => new { OrderItem = o, Order = op })
     .Where(x => x.Order.OrderDate == DateTime.Today && x.Order.IsSale == true)
     .Select(x => x.OrderItem.Order_Id)
     .Distinct()
     .Count();
            return query;

        }
        public int CountOrdersMonth()
        {
            int query = _context.OrderItems
         .Join(_context.Order,
               o => o.Order_Id,
               op => op.ID,
               (o, op) => new { OrderItem = o, Order = op })
         .Where(x => x.Order.OrderDate >= PreviousMonth && x.Order.OrderDate <= CurrentDate && x.Order.IsSale == true)
         .Select(x => x.OrderItem.Order_Id)
         .Distinct()
         .Count();
            return query;

        }
        public int CountOrdersYear()
        {
            int query = _context.OrderItems
         .Join(_context.Order,
               o => o.Order_Id,
               op => op.ID,
               (o, op) => new { OrderItem = o, Order = op })
         .Where(x => x.Order.OrderDate >= PreviousYear && x.Order.OrderDate <= CurrentDate && x.Order.IsSale == true)
         .Select(x => x.OrderItem.Order_Id)
         .Distinct()
         .Count();
            return query;

        }
        public int CountOrdersCustom(int id)
        {
            int query = _context.OrderItems
         .Join(_context.Order,
               o => o.Order_Id,
               op => op.ID,
               (o, op) => new { OrderItem = o, Order = op })
         .Where(x => x.Order.ID == id && x.Order.IsSale == true)
         .Select(x => x.OrderItem.Order_Id)
         .Distinct()
         .Count();
            return query;

        }
    }
}
