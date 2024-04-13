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
    internal class UserServices
    {
        StoreContext _context;
        public UserServices()
        {
            _context = new StoreContext();
        }
        public async Task<int> AddUser(User user)
        {
            await _context.User.AddAsync(user);
          return await _context.SaveChangesAsync();
            
        }
        public async Task<List<User>> GetALlUsers()
        {
            var Users = await _context.User.ToListAsync();
            if (Users != null)
            {
                return Users;
            }
            else
            {
                return new List<User>(); 
            }
        }
        public int GetLastBranchID()
        {
            Branch branch = _context.Branch.OrderByDescending(o => o.ID).FirstOrDefault();
            return branch.ID;

        }

        public async Task<User> GetUserByUserName(string username)
        {
            User user = await _context.User.FirstOrDefaultAsync(U => U.UserName == username);
            if (user != null)
            {
                return user;
            }
            else
            return new User();
        }
        public async Task<User> GetUserByID(int id)
        {
            User user = await _context.User.FirstOrDefaultAsync(U => U.ID == id);
            if (user != null)
            {
                return user;
            }
            else
                return new User();
        }
        public async Task<int> DeleteUser(string username)
        {
            var user = await _context.User.FirstOrDefaultAsync(u => u.UserName == username);
            if (user != null) {
               _context.User.Remove(user);
               await _context.SaveChangesAsync();
                return 1;
            }
            else
            return 0;
        }
        public async Task<int> UpdateUser(User user)
        {
            if (user != null)
            {
                await _context.SaveChangesAsync();
                return 1;
            }
            else
                return 0;
        }
        public async Task<bool> isUnique(string username)
        {
          User user=  await _context.User.FirstOrDefaultAsync(U => U.UserName == username);
            if(user == null)
            {
                return true;
            }
            return false;  
        }

        public async Task<List<User>> Search(string Name)
        {
            if (Name != "")
            {
                var users = await _context.User.Where(u => u.Name.Contains(Name)).ToListAsync();
                if (users != null)
                {
                    return users;
                }
                else
                {
                    return new List<User>();
                }
            }
            return new List<User>();
        }
    }
}
