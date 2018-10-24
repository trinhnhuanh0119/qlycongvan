using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class UsersController : Controller
    {
        IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }
        public async Task<IEnumerable<Users>> GetAllUsersPostsByPageIndex()
        {
            var reseltData = await _usersService.GetAllUsersByPageIndex(1, 6);

            return reseltData;
        }
    }
}