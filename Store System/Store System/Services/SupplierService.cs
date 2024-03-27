using Microsoft.EntityFrameworkCore;
using Store_System.Data;
using Store_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Store_System.Services
{
    internal class SupplierService
    {
        StoreContext _context;

        public SupplierService()
        {
            _context = new StoreContext();
        }

        public async Task<int> AddSupplier(Supplier supplier)
        {
            try
            {
                await _context.Supplier.AddAsync(supplier);
                return await _context.SaveChangesAsync();
            }catch(Exception ex)
            {
                MessageBox.Show("لا يمكن إضافة نفس المورد مرتان", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public async Task<Supplier> GetSupplier(int id)
        {
            Supplier supplier =await _context.Supplier.FirstOrDefaultAsync(S => S.ID == id);
            if(supplier != null) {
                return supplier;
            }
            return new Supplier();
        }

        public async Task<List<Supplier>> GetAllSuppliers()
        {
            var suppliers= await _context.Supplier.ToListAsync();
            if(suppliers!=null)
            {
                return suppliers;
            }
            else
            {
                return new List<Supplier>();
            }
        }

        
        public async Task<int> UpdateSupplier(Supplier supplier)
        {
            if (supplier != null)
            {
                return await _context.SaveChangesAsync();
            }
            else 
            {
                return 0; 
            }

        }
        public async Task<List<Supplier>> Search(string Name)
        {
            if (Name != "")
            {
                var suppliers = await _context.Supplier.Where(p => p.Name.Contains(Name)).ToListAsync();
                if (suppliers != null)
                {
                    return suppliers;
                }
                else
                {
                    return new List<Supplier>();
                }
            }
            return new List<Supplier>();
        }


    }
}
