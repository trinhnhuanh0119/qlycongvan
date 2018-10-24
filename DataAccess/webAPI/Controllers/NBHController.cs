using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class NBHController : Controller
    {
        INBHService _nbhService;

        public NBHController(INBHService nbhService)
        {
            _nbhService = nbhService;
        }
        public async Task<IEnumerable<NBH>> GetAllNBHPostsByPageIndex()
        {
            var reseltData = await _nbhService.GetAllNBHByPageIndex(1, 6);

            return reseltData;
        }
    }
}