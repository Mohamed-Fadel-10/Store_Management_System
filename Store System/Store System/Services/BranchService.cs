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
