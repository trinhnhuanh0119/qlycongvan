using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class CCQBHController : Controller
    {
        ICCQBHService ccqbhService;
        public CCQBHController()
        {

        }
        public CCQBHController(ICCQBHService ccqbhService)
        {
            ccqbhService = ccqbhService;
        }
        public async Task<IEnumerable<CCQBH>> GetAllCCQBHPostsByPageIndex()
        {
            var reseltData = await ccqbhService.GetAllCCQBHByPageIndex(1, 6);
            
                return reseltData; 
           
            
        }
    }
}