using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class SVBController : Controller
    {
        ISVBService _svbService;

        public SVBController(ISVBService svbService)
        {
            _svbService = svbService;
        }
        public async Task<IEnumerable<SVB>> GetAllSVBPostsByPageIndex()
        {
            var reseltData = await _svbService.GetAllSVBByPageIndex(1, 6);

            return reseltData;
        }
    }
}