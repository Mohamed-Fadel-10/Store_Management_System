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
    internal class BranchService
    {
        StoreContext _context;

        public BranchService()
        {
            _context = new StoreContext();
        }

        public async Task<int> AddBranch(Branch branch)
        {
            if (branch != null)
            {
                await _context.Branch.AddAsync(branch);
                await _context.SaveChangesAsync();
                return 1;

            }
            else
            {
                return 0;
            }

        }
        public async Task<List<Branch>> getAll()
        {

            return await _context.Branch.ToListAsync();
        }
        public async Task<int> UpdateProduct(Branch branch)
        {

            if (branch != null)
            {
                return await _context.SaveChangesAsync();
            }
            else
            {
                return 0;
            }
        }
        public async Task<Branch> GetLastBranchID()
        {
            Branch id = await _context.Branch.OrderByDescending(o => o.ID).FirstOrDefaultAsync();
            return id;
        }
        public async Task<double> SumStockMoney()
        {
           
            return await _context.Branch.SumAsync(b => b.MainMoneyStock);
        }

        public async Task<Branch> GetBranchByID(int id)
        {
            Branch branch = await _context.Branch.FirstOrDefaultAsync(b => b.ID == id);
            if (branch != null)
            {
                return branch;
            }
            else
                return new Branch();
        }
    }
}
