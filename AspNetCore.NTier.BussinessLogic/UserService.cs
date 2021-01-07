using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AspNetCore.NTier.DataAccess.Entities;
using AspNetCore.NTier.DataAccess.Functions;

namespace AspNetCore.NTier.BussinessLogic
{
    public class UserService
    {
        UserStore userStore = new UserStore();
        public async Task<bool> AddUser(string firstName,string lastName,string email)
        {
            return await userStore.AddUser(firstName, lastName, email);
        }
        public async Task<List<User>> GetUsers()
        {
            return await userStore.GetUsers();
        }
    }
}
