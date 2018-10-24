using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class MenuController : Controller
    {
        IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }
        public async Task<IEnumerable<Menu>> GetAllMenuPostsByPageIndex()
        {
            var reseltData = await _menuService.GetAllMenuByPageIndex(1, 6);

            return reseltData;
        }
    }
}