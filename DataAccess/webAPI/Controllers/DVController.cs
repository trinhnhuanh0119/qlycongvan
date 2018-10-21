using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    public class DVController : Controller
    {
        IDVService _dvService;

        public DVController(IDVService dvService)
        {
            _dvService = dvService;
        }
        public async Task<IEnumerable<DV>> GetAllDVPostsByPageIndex()
        {
            var reseltData = await _dvService.GetAllDVByPageIndex(1, 6);

            return reseltData;
        }
    }
}