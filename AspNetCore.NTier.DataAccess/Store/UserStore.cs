using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCore.NTier.DataAccess.DataContext;
using AspNetCore.NTier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.NTier.DataAccess.Functions
{
    public class UserStore
    {
        private AppDbContext dbContext = new AppDbContext();
        
        public async Task<bool> AddUser(string firstName, string lastName, string email)
        {
            try
            {
                var user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email
                };
                await dbContext.Users.AddAsync(user);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public async Task<List<User>> GetUsers()
        {
            return await dbContext.Users.ToListAsync();
        }
    }
}
