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
    internal class CategoryService
    {
        StoreContext _context;
        public CategoryService()
        {
            _context = new StoreContext();
        }
        public async Task<int> AddCategory(Category Category)
        {
            if (Category != null)
            {
                await _context.Category.AddAsync(Category);
                await _context.SaveChangesAsync();
                return Category.ID;
            }
            else
            {
                return 0;
            }
        }
        public async Task<bool> IsUniqe(string code)
        {
          Category category=  await _context.Category.FirstOrDefaultAsync(c => c.Code == code);
            if (category == null)
            {
                return true;
            }
            else
                return false;
        }

        public async Task<List<Category>> GetALlCategories()
        {
            var Categories = await _context.Category.ToListAsync();
            if (Categories != null)
            {
                return Categories;
            }
            else
            {
                return new List<Category>();
            }
        }
        

        public async Task<List<Category>> Search(string Name)
        {
            if (Name != "")
            {
                var Categories = await _context.Category.Where(p => p.Name.Contains(Name)).ToListAsync();
                if (Categories != null)
                {
                    return Categories;
                }
                else
                {
                    return new List<Category>();
                }
            }
            return new List<Category>();
        }


    }
}
