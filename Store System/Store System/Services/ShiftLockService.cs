using Microsoft.EntityFrameworkCore;
using Store_System.Data;
using Store_System.Models;
using Store_System.UI.ControlPanelUi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Services
{
    internal class ShiftLockService
    {
        StoreContext _context;
        User user;
        Branch branch;
        public ShiftLockService()
        {
            _context = new StoreContext();
            branch = new Branch();
            //user = new User();

        }

        public static event EventHandler<double> ShiftMoneyChanged;

        public static void GetShiftMoneyChanged(double money)
        {
            ShiftMoneyChanged.Invoke(null, money);
        }

        
        public async Task<int>UpdateMoney(int user_id,int branch_id,double money)
        {
            User userID = await _context.User.FirstOrDefaultAsync(u => u.ID == user_id);
            Branch branch = await _context.Branch.FirstOrDefaultAsync(b => b.ID == branch_id);

            if (userID != null&&branch!=null)
            {
                userID.MoneyStockAmount += money;
                branch.MainMoneyStock += money;
                return await _context.SaveChangesAsync();
            }

            return 0;
        }
    }
}
