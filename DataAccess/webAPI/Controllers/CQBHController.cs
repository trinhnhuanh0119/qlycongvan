using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class CQBHController : Controller
    {
        ICQBHService _cqbhService;
     
        public CQBHController(ICQBHService cqbhService)
        {
            _cqbhService = cqbhService;
        }
        public async Task<IEnumerable<CQBH>> GetAllCQBHPostsByPageIndex()
        {
            var reseltData = await _cqbhService.GetAllCQBHByPageIndex(1, 6);

            return reseltData;
        }
    }
}