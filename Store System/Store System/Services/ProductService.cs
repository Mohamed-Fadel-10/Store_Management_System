using Microsoft.EntityFrameworkCore;
using Store_System.Data;
using Store_System.Models;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Services
{
    internal class ProductService
    {
        StoreContext _context;
        public ProductService()
        {
            _context = new StoreContext();
        }
        public async Task<int> AddProduct(Product product)
        {
            if (product != null)
            {
                await _context.Product.AddAsync(product);
                await _context.SaveChangesAsync();
                return 1; 
            }
            else {
                return 0;
            }
            
        }
        public int DeleteProduct(string Barcode)
        {
            var Product = _context.Product.FirstOrDefault(u => u.Barcode == Barcode);
            if (Product != null)
            {
                _context.Product.Remove(Product);
                 _context.SaveChanges();
                return 1;
            }
            else
                return 0;
        }
        public async Task<List<Product>> GetAllProducts()
        {
          var Products=  await _context.Product.Include(P=>P.Category).ToListAsync();
            if (Products!=null)
            {
                return Products;
            }
            return new List<Product>();
        }
        

        public async Task<int>UpdateProduct(Product product)
        {
            
            if (product != null)
            { 
                return await _context.SaveChangesAsync();
            }
            else
            {
                return 0;
            }
        }
        public async Task<Product> GetProductByBarcode(string Barcode)
        {
            var Product = await _context.Product.FirstOrDefaultAsync(p => p.Barcode == Barcode);
            if(Product != null)
            {
                return Product;
            }
            else
            {
                return new Product();
            }

        }


        public async Task<Product> GetProductByID(int id)
        {
            var Product = await _context.Product.FirstOrDefaultAsync(p => p.ID == id);
            if (Product != null)
            {
                return Product;
            }
            else
            {
                return new Product();
            }

        }


        public async Task<List<Product>>Search(string Name)
        {
            if (Name != "") { 
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
        public async Task<bool> IsUniqe(string code)
        {
            Product category = await _context.Product.FirstOrDefaultAsync(c => c.Barcode == code);
            if (category == null)
            {
                return true;
            }
            else
                return false;
        }

    }
}
