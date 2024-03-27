using Store_System.Data;
using Store_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Services
{
    internal class SuppliersProductsService
    {
        StoreContext _context;
        public SuppliersProductsService()
        {
            _context = new StoreContext();
        }
        public async Task<int> addSuppliersforProducts(ProductsSuppliers productsSuppliers)
        {
            if (productsSuppliers != null)
            {
                await _context.ProductsSuppliers.AddAsync(productsSuppliers);
                int row = await _context.SaveChangesAsync();
                return row;
            }
            else
            {
                return 0;
            }

        }
    }
}
