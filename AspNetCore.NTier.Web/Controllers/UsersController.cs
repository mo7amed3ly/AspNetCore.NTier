using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.NTier.BussinessLogic;
using AspNetCore.NTier.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.NTier.Web.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService userService=new UserService();
        [HttpGet]
        [Route("add")]
        public async Task<bool> AddUser(string firstName,string lastName,string email)
        {
            return await userService.AddUser(firstName, lastName, email);
        }
        [HttpGet]
        [Route("list")]
        public async Task<IEnumerable<UserViewModel>> GetUsers()
        {
            var users = await userService.GetUsers();
            return users.Select(u => 
            new UserViewModel 
            { FirstName = u.FirstName, LastName = u.LastName, Email = u.Email }
            );
        }
    }
}
