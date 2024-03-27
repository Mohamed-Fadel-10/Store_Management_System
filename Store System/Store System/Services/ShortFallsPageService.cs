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
    internal class ShortFallsPageService
    {
        StoreContext _context;
        public ShortFallsPageService()
        {
            _context = new StoreContext();
        }
        public async Task<List<Product>> GetAllShortFalls()
        {
            var shortsProducts = await _context.Product
                .Include(p => p.Category) 
                .Where(p => p.StockAmount == 0)
                .ToListAsync();

            return shortsProducts;
        }

        public async Task<int> CountShorts()
        {
          var Amount= await _context.Product.CountAsync(p=>p.StockAmount==0);
            return Amount;
        }
        public async Task<List<Product>> Search(string Name)
        {
            if (Name != "")
            {
                var Products = await _context.Product.Where(p => p.Name.Contains(Name)&&p.StockAmount==0).ToListAsync();
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
