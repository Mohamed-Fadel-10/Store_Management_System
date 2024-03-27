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
    internal class MainStockService
    {
        private StoreContext _context;
        public MainStockService()
        {
            _context = new StoreContext();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            _context = new StoreContext();

            var AllProducts = await _context.Product
                .Include(p => p.Category)
                .Where(p=>p.StockAmount>4)
                .ToListAsync();
            return AllProducts;
        }
        public async Task<List<Product>> ProductsWillShorts()
        {
            _context = new StoreContext();

            var AllProducts = await _context.Product
                .Include(p => p.Category)
                .Where(p=>p.StockAmount<=4 && p.StockAmount > 0) // if Items is 3 then  system will notify the Cashier
                .ToListAsync();
               return AllProducts;
        }
        public async Task<List<Product>> ProductsBasedOnCategory(int CategoryID)
        {
            _context = new StoreContext();
            var AllProducts = await _context.Product
                .Include(p => p.Category)
                .Where(p => p.Category.ID == CategoryID)
                .ToListAsync();
            return AllProducts;
        }
        public async Task<int> CountsAll()
        {
            _context = new StoreContext();

            var Amount = await _context.Product.CountAsync();
            return Amount;
        }
        public async Task<int> CountShorts()
        {
            _context = new StoreContext();
            var Amount = await _context.Product.CountAsync(p => p.StockAmount == 0);
            return Amount;
        }
        public async Task<double> CountMoney()
        {
            _context = new StoreContext();

            double Amount = await _context.Branch.SumAsync(p=>p.MainMoneyStock);
            return Amount;
        }
        public async Task<List<Product>> Search(string Name)
        {
            if (Name != "")
            {
                var Products = await _context.Product.Where(p => p.Name.Contains(Name)).ToListAsync();
                if (Products != null)
                {
                    return Products;
                }
                else
                {
                    return new List<Product>();
                }
            }
            return new List<Product>();
        }
    }
}
